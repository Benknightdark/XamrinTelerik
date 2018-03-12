using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Xamarin.Forms;

namespace xamarinui
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            UserDialogs.Instance.ShowLoading("Loading", MaskType.Black);
		}
        private void button_Clicked(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("shit");
            //implement your logic here.
        }
    }
}
