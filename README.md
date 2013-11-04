test-nested-view-model
======================

Trivial example showing problems composing views in ASP.NET MVC 4 using partials and nested view models

I'm trying to illustrate composing a view. I suspect a better method would be `EditorFor` but that approach doesn't seem as rich as using partials (how would I use different editors for the same view model in a different context?).


## The views look like this:

`Index.cshtml`

	@model NestedViewModel.Models.HomeViewModel

	<p>
	    @Html.LabelFor(x => x.HomeViewModelField)
	    @Html.TextBoxFor(x => x.HomeViewModelField)
	</p>

	@Html.Partial("_Nested", Model.Nested)

`_Nested.cshtml`

	@model NestedViewModel.Models.MyNestedViewModel

	<p>
	    @Html.LabelFor(x => x.NestedViewModelField)
	    @Html.TextBoxFor(x => x.NestedViewModelField)
	</p>

## The result looks like this:

	<p>
	    <label for="HomeViewModelField">HomeViewModelField</label>
	    <input id="HomeViewModelField" name="HomeViewModelField" type="text" value="" />
	</p>

	<p>
	    <label for="NestedViewModelField">NestedViewModelField</label>
	    <input id="NestedViewModelField" name="NestedViewModelField" type="text" value="" />
	</p>

Note that `NestedViewModelField`'s name won't bind back to the view model. For model binding to work the name should be `Nested.NestedViewModelField`.


