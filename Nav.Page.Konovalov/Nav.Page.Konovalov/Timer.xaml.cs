using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nav.Page.Konovalov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Timer : ContentPage
    {
        string[] hard = new string[] { "Nvidia", "AMD", "Intel" };
        public Timer()
        {
            InitializeComponent();
            hardware.ItemsSource = hard;
            hardware.SelectedIndexChanged += Hardware_SelectedIndexChanged;
        }

        private void Hardware_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (hardware.SelectedIndex)
            {
                case 0:
                    nvidianfo.IsVisible = true;
                    Nvid.IsVisible = true;
                    amd.IsVisible = false;
                    amdinfo.IsVisible = false;
                    intel.IsVisible = false;
                    intelinfo.IsVisible = false;
                    break;
                case 1:
                    nvidianfo.IsVisible = false;
                    Nvid.IsVisible = false;
                    amd.IsVisible = true;
                    amdinfo.IsVisible = true;
                    intel.IsVisible = false;
                    intelinfo.IsVisible = false;
                    break;
                case 2:
                    amd.IsVisible = false;
                    amdinfo.IsVisible = false;
                    nvidianfo.IsVisible = false;
                    Nvid.IsVisible = false;
                    intelinfo.IsVisible = true;
                    intel.IsVisible = true;
                    break;
            }
        }
    }
}