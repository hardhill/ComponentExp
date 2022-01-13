using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ComponentExp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Selector : ContentView
    {
        public Selector()
        {
            InitializeComponent();
            
        }
        public static readonly BindableProperty SelectedIndexProperty = BindableProperty.Create(nameof(SelectedIndex), typeof(int), typeof(Selector), defaultValue:0);
        public int SelectedIndex 
        { get{
                return (int)GetValue(SelectedIndexProperty);
            }
          set {
                SetValue(SelectedIndexProperty, value);       
            } 
        }
        public delegate void SelectorDelegate(object sender,  int index);
        public event SelectorDelegate SelectedChanged;

        //=========================================================================
        public bool IsPrivate { get { return (bool)GetValue(IsPrivateProperty); } set { SetValue(IsPrivateProperty, value); } }
        public static readonly BindableProperty IsPrivateProperty = BindableProperty.Create(nameof(IsPrivate), typeof(bool), typeof(Selector), defaultValue:false);
        public delegate void IsPrivateDelegate(object sender, bool share);
        public event IsPrivateDelegate IsPrivateChanged;

        private void picLandmarkTapped(object sender, EventArgs e)
        {
            resetColorBackground();
            picLandmark.BackgroundColor = Color.FromHex("#82CCFF");
            picLandmark.HasShadow = false;
            txtInfo.Text = "Landmark";
            SelectedIndex = 0;
            SelectedChanged?.Invoke(this, SelectedIndex);
        }
        private void picCampingTapped(object sender, EventArgs e)
        {
            resetColorBackground();
            picCamping.BackgroundColor = Color.FromHex("#82CCFF");
            picCamping.HasShadow = false;
            txtInfo.Text = "Camping";
            SelectedIndex = 1;
            SelectedChanged?.Invoke(this, SelectedIndex);
        }
        private void picBeautyTapped(object sender, EventArgs e)
        {
            resetColorBackground();
            picBeauty.BackgroundColor = Color.FromHex("#82CCFF");
            picBeauty.HasShadow = false;
            txtInfo.Text = "Beauty Place";
            SelectedIndex = 2;
            SelectedChanged?.Invoke(this, SelectedIndex);
        }
        private void picPointTapped(object sender, EventArgs e)
        {
            resetColorBackground();
            picPoint.BackgroundColor = Color.FromHex("#82CCFF");
            picPoint.HasShadow = false;
            txtInfo.Text = "Point of Interest";
            SelectedIndex = 3;
            SelectedChanged?.Invoke(this, SelectedIndex);
        }
        private void picTrashTapped(object sender, EventArgs e)
        {
            resetColorBackground();
            picTrash.BackgroundColor = Color.FromHex("#82CCFF");
            picTrash.HasShadow = false;
            txtInfo.Text = "Trash";
            SelectedIndex = 4;
            SelectedChanged?.Invoke(this, SelectedIndex);
        }
        private void picSportTapped(object sender, EventArgs e)
        {
            resetColorBackground();
            picSport.BackgroundColor = Color.FromHex("#82CCFF");
            picSport.HasShadow = false;
            txtInfo.Text = "Sport place";
            SelectedIndex = 5;
            SelectedChanged?.Invoke(this, SelectedIndex);
        }

        private void resetColorBackground()
        {
            picLandmark.BackgroundColor = Color.White;
            picCamping.BackgroundColor = Color.White;
            picBeauty.BackgroundColor = Color.White;
            picPoint.BackgroundColor = Color.White;
            picTrash.BackgroundColor = Color.White;
            picSport.BackgroundColor = Color.White;
            picLandmark.HasShadow = true;
            picCamping.HasShadow = true;
            picBeauty.HasShadow = true;
            picPoint.HasShadow = true;
            picTrash.HasShadow = true;
            picSport.HasShadow = true;
        }

        private void Switch_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "IsToggled")
            {
                IsPrivateChanged?.Invoke(this, swPrivate.IsToggled);
            }
        }
    }
}