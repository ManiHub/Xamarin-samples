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
                
                switch (itemselected)
                {
                    case 0:
                        this.img_1.Source = "Images/apple.png";
                        this.lb_1.Text = "Apple";
                        break;
                    case 1:
                        img_1.Source = "Images/mango.png";
                        lb_1.Text = "Mango";
                        break;
                    case 2:
                        img_1.Source = "Images/grapes.png";
                        lb_1.Text = "Graphs";
                        break;
                    default:
                        break;
                }
                
            }catch(Exception exp)
            {

            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (entry_1.Text != null && entry_1.Text.ToString().Length > 0)
            {
                picker_2.Items.Add(entry_1.Text.ToString());
            }
        }
    }
}