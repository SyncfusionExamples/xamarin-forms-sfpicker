using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Picker_GettingStarted
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            picker.IsOpen = true;
        }
    }
    public class ColorInfo
    {

        private ObservableCollection<string> _color;

        public ObservableCollection<string> Colors

        {

            get { return _color; }

            set { _color = value; }

        }

        public ColorInfo()

        {

            Colors = new ObservableCollection<string>();

            Colors.Add("Red");

            Colors.Add("Green");

            Colors.Add("Yellow");

            Colors.Add("Blue");

            Colors.Add("SkyBlue");

            Colors.Add("Orange");

            Colors.Add("Gray");

            Colors.Add("Pink");

        }

    }
}
