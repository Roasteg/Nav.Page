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
    public partial class Guitars : ContentPage
    {
        ListView lst = new ListView();
        string[] myList = new string[] {"Fender", "Gibson", "Ibanez", "Yamaha", "Esp", "Jackson"};
        public Guitars()
        {
            lst.ItemsSource = myList;
            Content = new StackLayout { Children = { lst } };
            lst.ItemTapped += Lst_ItemTapped;
        }

        private void Lst_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListView lst = (ListView)sender;
            switch (lst.SelectedItem)
            {
                case "Fender":
                    DisplayAlert("Инфо", "Fender — американская компания, производящая электрические и акустические гитары, музыкальное оборудование.\n Занимает одно из лидирующих мест на рынке музыкальных инструментов. омпания «Fender Musical Instruments Corporation» основана Лео Фендером (Clarence «Leo» Fender) в Калифорнии в 1946 году.", "Ok");
                    break;
                case "Gibson":
                    DisplayAlert("Инфо", "Gibson (Гибсон) — американская компания, производитель гитар. Продукцию фирмы можно также увидеть под брендами Epiphone, Kramer Guitars, Valley Arts, Tobias, Steinberger и Kalamazoo. Помимо гитар Гибсон изготавливает фортепиано (подразделение компании — Baldwin Piano), барабаны и дополнительное оборудование. \n Основана Орвиллом Гибсоном в 1920 году", "Ok");
                    break;
                case "Ibanez":
                    DisplayAlert("Инфо", "Ibanez — гитарный бренд, которым владеет компания Hoshino Gakki, расположенная в городе Нагоя, Япония. \n Основана 1929.", "Ok");
                    break;
                case "Yamaha":
                    DisplayAlert("Инфо", "Yamaha Corporation — японская транснациональная компания, крупнейший производитель музыкальных инструментов, также занимается производством акустических систем, звукового оборудования и спортивного инвентаря. Штаб-квартира компании расположена в г. Хамамацу (префектура Сидзуока). Основана 12 октября 1887 года.", "Ok");
                    break;
                case "Esp":
                    DisplayAlert("Инфо", "Electric Sound Products — японская компания, которая производит гитары, расположена в Токио (Япония) и Лос-Анджелесе (США).\n Компания была основана японцем Хисатакэ Сибуей в 1975 году как цепочка музыкальных магазинов в Японии.", "Ok");
                    break;
                case "Jackson":
                    DisplayAlert("Инфо", "«Jackson» — фирма-производитель гитар первоначально принадлежавшая Гроверу Джексону (Grover Jackson), партнёру Уэйна Чарвэла (Wayne Charvel) владельца гитарной мастерской Charvel Guitar Repair.\n Основана в 1980 году.", "Ok");
                    break;
            }
        }
    }
}