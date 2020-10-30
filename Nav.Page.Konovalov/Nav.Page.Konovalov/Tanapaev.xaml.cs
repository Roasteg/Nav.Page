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
    public partial class Tanapaev : ContentPage
    {
        
        public Tanapaev()
        {
            InitializeComponent();
            today.Date = DateTime.Now;
        }
    }
}