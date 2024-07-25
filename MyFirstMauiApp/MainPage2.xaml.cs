using MyFirstMauiApp.ViewModel;

namespace MyFirstMauiApp
{
    public partial class MainPage2 : ContentPage
    {
        int count = 0;

        public MainPage2(MainPage2ViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;

        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

           // if (count == 1)
                //CounterBtn.Text = $"Clicked {count} time";
            //else
               // CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
