

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MyFirstMauiApp.ViewModel
{
    //public class MainPage2ViewModel : INotifyPropertyChanged
    public partial class MainPage2ViewModel : ObservableObject

    {

        public MainPage2ViewModel() {

            Items = new ObservableCollection<string>();

        
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;


        //public string Text
        //{
        //    get => text;
        //    set
        //    {
        //        text = value;
        //        OnPropertyChanged(nameof(Text));

        //    }
        //}
        //public event PropertyChangedEventHandler PropertyChanged;

        //void OnPropertyChanged(string name) =>
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

       [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
            {
                return;
            }
            Items.Add(Text);

            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string s)
        {
            if (Items.Contains(s))
            Items.Remove(s);
        }

    }
}
