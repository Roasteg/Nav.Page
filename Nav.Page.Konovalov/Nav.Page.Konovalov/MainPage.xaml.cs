using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nav.Page.Konovalov
{
    public partial class MainPage : ContentPage
    {
        StackLayout stack = new StackLayout();
        List<Button> buttons = new List<Button>();
        public MainPage()
        {
            
            for (int i = 0; i < 8; i++)
            {
                Button btn = new Button()
                {
                    Text = $"Page {i}"
                };
                buttons.Add(btn);
                stack.Children.Add(btn);
            }
            Content = stack;
            buttons[0].Text = "Производители гитар";
            buttons[0].Clicked += MainPage_Clicked;
            buttons[1].Text = "Усилители";
            buttons[1].Clicked += MainPage_Clicked1;
            buttons[2].Text = "Entry";
            buttons[2].Clicked += MainPage_Clicked2;
            buttons[3].Text = "Picker";
            buttons[3].Clicked += MainPage_Clicked3;
            buttons[4].Text = "DateTime (current)";
            buttons[4].Clicked += MainPage_Clicked4;
        }

        private async void MainPage_Clicked4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tanapaev());
        }

        private async void MainPage_Clicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer());
        }

        private async void MainPage_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Hardware());
        }

        private async void MainPage_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Amps());
        }

        private async void MainPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Guitars());
        }
    }
}
