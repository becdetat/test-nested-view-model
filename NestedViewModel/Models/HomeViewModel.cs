namespace NestedViewModel.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            Nested = new MyNestedViewModel();
        }

        public string HomeViewModelField { get; set; }
        public MyNestedViewModel Nested { get; set; }
    }
}