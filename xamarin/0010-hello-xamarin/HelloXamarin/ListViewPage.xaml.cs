using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ObservableCollection<Customer> Customers { get; } = new ObservableCollection<Customer>
        {
            new Customer { FirstName = "John", LastName = "Doe" },
            new Customer { FirstName = "Jane", LastName = "Smith" },
            new Customer { FirstName = "Foo", LastName = "Bar" },
        };

        public ListViewPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void OnAdd(object sender, EventArgs e)
        {
            Customers.Add(new Customer
            {
                FirstName = "Andy",
                LastName = $"Somebody{new Random().Next(10000, 99999)}"
            });
        }

        private async void OnBack(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
