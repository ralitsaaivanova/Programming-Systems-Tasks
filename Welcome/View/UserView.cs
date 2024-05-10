using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        private UserViewModel _viewModel;

        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public UserViewModel ViewModel
        {
            get { return _viewModel; }
            private set { _viewModel = value; }
        }

        public void Display()
        {
            if (_viewModel != null)
            {
                Console.WriteLine("Welcome " + _viewModel.Names + " " + _viewModel.Password);
            }
            else
            {
                Console.WriteLine("ViewModel is not initialized.");
            }
        }

        public void DisplayError()
        {
            throw new Exception("Error thrown by UserView class!");
        }
    }
}
