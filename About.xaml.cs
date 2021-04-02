using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovieApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class About : ContentPage
    {
        public About()
        {
            this.BackgroundColor = Color.LightSkyBlue;
            StackLayout stack = new StackLayout();

            
            Label label = new Label
            {
                Text = "Institution: Seneca College" +
                "\nName: Uliana Rozzhyvaikina" +
                "\nCourse: MAP526" +
                "\nApp name: MovieApp" +
                "\nDate: 2021-02-27",
                FontSize = 30,
                Margin = 15
            };

           
            stack.Children.Add(label);

            Content = stack;
        }
    }
}