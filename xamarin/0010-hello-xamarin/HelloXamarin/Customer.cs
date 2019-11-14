using System.ComponentModel;

namespace HelloXamarin
{
    // Note that in practice, you would use a helper library for
    // MVVM. Examples:
    //   - Prism (https://prismlibrary.github.io/docs/xamarin-forms/creating-your-first-prism-app.html)
    //   - MVVMLight
    // Here we write everything from scratch to understand what is
    // going on behind the scenes.

    public class Customer : INotifyPropertyChanged
    {
        private string FirstNameValue = "Foo";
        public string FirstName
        {
            get => FirstNameValue;
            set
            {
                FirstNameValue = value;
                RaisePropertyChanged(nameof(FirstName));
                RaisePropertyChanged(nameof(FullName));
                RaisePropertyChanged(nameof(IconUrl));
            }
        }

        private string LastNameValue = "Bar";
        public string LastName
        {
            get => LastNameValue;
            set
            {
                LastNameValue = value;
                RaisePropertyChanged(nameof(FirstName));
                RaisePropertyChanged(nameof(FullName));
                RaisePropertyChanged(nameof(IconUrl));
            }
        }

        public string FullName
        {
            get => $"{LastName}, {FirstName}";
        }

        public string IconUrl
        {
            get => $"https://robohash.org/{LastName}-{FirstName}.png";
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
