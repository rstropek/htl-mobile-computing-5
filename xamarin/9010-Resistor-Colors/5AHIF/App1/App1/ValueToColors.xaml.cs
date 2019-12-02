using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ValueToColors : ContentPage
    {
        public decimal Input { get; set; }

        public string ResultValue;
        public string Result
        {
            get => ResultValue;
            set
            {
                ResultValue = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public ValueToColors()
        {
            InitializeComponent();

            BindingContext = this;
        }

        private void CalculateColors(object sender, EventArgs e)
        {
            long fl;

            string color1;
            string color2;
            string color3;

            if (Input % 1 == 0)
            {
                fl = (long)Input;

                int position;
                for(position = 0; fl >= 100; position++)
                {
                    if (fl % 10 != 0)
                    {
                        Result = "Number cannot be converted";

                        return;
                    }
                    fl /= 10;
                }

                /* int position = 0;
                while (fl >= 100)
                {
                    if (fl % 10 != 0)
                    {
                        Result = "Number cannot be converted";

                        return;
                    }
                    fl /= 10;

                    position++;
                }*/

                switch (position)
                {
                    case 0: color3 = "Black"; break;
                    case 1: color3 = "Brown"; break;
                    case 2: color3 = "Red"; break;
                    case 3: color3 = "Orange"; break;
                    case 4: color3 = "Yellow"; break;
                    case 5: color3 = "Green"; break;
                    case 6: color3 = "Blue"; break;
                    case 7: color3 = "Violet"; break;
                    case 8: color3 = "Grey"; break;
                    case 9: color3 = "White"; break;
                    default: Result = "Number cannot be converted"; return;
                }
            }
            else if (Input * 10 % 1 == 0)
            {
                fl = (int)(Input * 10);

                color3 = "Gold";
            }
            else if (Input * 100 % 1 == 0)
            {
                fl = (int)(Input * 100);

                color3 = "Silver";
            }
            else
            {
                Result = "Number cannot be converted";

                return;
            }

            switch (fl % 10)
            {
                case 0: color2 = "Black"; break;
                case 1: color2 = "Brown"; break;
                case 2: color2 = "Red"; break;
                case 3: color2 = "Orange"; break;
                case 4: color2 = "Yellow"; break;
                case 5: color2 = "Green"; break;
                case 6: color2 = "Blue"; break;
                case 7: color2 = "Violet"; break;
                case 8: color2 = "Grey"; break;
                case 9: color2 = "White"; break;
                default: Result = "Number cannot be converted"; return;
            }

            switch ((int)(fl / 10))
            {
                case 0: color1 = "Black"; break;
                case 1: color1 = "Brown"; break;
                case 2: color1 = "Red"; break;
                case 3: color1 = "Orange"; break;
                case 4: color1 = "Yellow"; break;
                case 5: color1 = "Green"; break;
                case 6: color1 = "Blue"; break;
                case 7: color1 = "Violet"; break;
                case 8: color1 = "Grey"; break;
                case 9: color1 = "White"; break;
                default: Result = "Number cannot be converted"; return;
            }

            Result = $"Color 1: {color1}\nColor 2: {color2}\nColor 3: {color3}";
        }
    }
}