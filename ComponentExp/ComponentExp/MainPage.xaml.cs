using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ComponentExp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        

        private void Selector_SelectedChanged(object sender, int index)
        {
            Console.WriteLine($"Selected {index}");
        }

        private void Selector_IsPrivateChanged(object sender, bool share)
        {
            Console.WriteLine($"Is private: {share}");
        }
    }
}
