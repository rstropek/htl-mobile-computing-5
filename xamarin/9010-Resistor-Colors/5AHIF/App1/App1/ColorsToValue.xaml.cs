using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColorsToValue : ContentPage, INotifyPropertyChanged
    {
        public ColorsToValue()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public List<string> Colors { get; } = new List<string>
        {
            "black", "brown", "red", "orange", "yellow", "green", "blue", "purple", "grey", "white"
        };



        private string SelectedColor1Value;
        public string SelectedColor1
        {
            get => SelectedColor1Value;
            set
            {
                SelectedColor1Value = value;
                OnPropertyChanged(nameof(SelectedColor1));
            }
        }


        private string SelectedColor2Value;
        public string SelectedColor2
        {
            get => SelectedColor2Value;
            set
            {
                SelectedColor2Value = value;
                OnPropertyChanged(nameof(SelectedColor2));
            }
        }


        private string SelectedColor3Value;
        public string SelectedColor3
        {
            get => SelectedColor3Value;
            set
            {
                SelectedColor3Value = value;
                OnPropertyChanged(nameof(SelectedColor3));
            }
        }

        private Int64 ResultValue;
        public Int64 Result
        {
            get => ResultValue;
            set
            {
                ResultValue = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        private void CalculateResistor(object sender, EventArgs e)
        {
            // Get the index of the colors
            var index1 = Colors.IndexOf(SelectedColor1Value);
            var index2 = Colors.IndexOf(SelectedColor2Value);
            var index3 = Colors.IndexOf(SelectedColor3Value);

            // Calculate the result
            var result = (index1 * 10 + index2) * ((Int64)Math.Pow(10, index3));

            // Set the result
            Result = result;
        }
    }
}