using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicControls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerPage : ContentPage
	{
		public PickerPage ()
		{
			InitializeComponent ();
            Init();
		}

        private void Init()
        {
            try
            {
                var _pickerlist = new List<string> {
                "Apple",
                "Mango",
                "Graphs"
                };

                picker_1.Title = "Select a Fruit";
                picker_1.ItemsSource = _pickerlist;
            }catch(Exception e)
            {

            }
        }

        private void picker_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int itemselected = picker_1.SelectedIndex;
                Image img = null;
                Label lb = null;

                switch (itemselected)
                {
                    case 0:
                        img = new Image();
                        lb = new Label();
                        img.Source = "";
                        lb.Text = "Apple";
                        break;
                    case 1:
                        img = new Image();
                        lb = new Label();
                        img.Source = "";
                        lb.Text = "Mango";
                        break;
                    case 2:
                        img = new Image();
                        lb = new Label();
                        img.Source = "";
                        lb.Text = "Graphs";
                        break;
                    default:
                        break;
                }
                
                if(img!=null && lb != null)
                {
                    sl_1.Children.Add(img);
                    sl_1.Children.Add(lb);
                }

            }catch(Exception exp)
            {

            }
        }
    }
}