using ComponentExp.Model;
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
        public SimpleData simpleData { get; set; }
        public MainPage()
        {
            InitializeComponent();
            simpleData = new SimpleData();
            simpleData.CategoryId = 4;
            simpleData.IsPrivate = true;
            BindingContext = simpleData;
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
