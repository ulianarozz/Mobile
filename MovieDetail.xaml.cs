using SQLite;
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
    public partial class MovieDetail : ContentPage
    {
        Movie selectedMovie;
        public MovieDetail(Movie selectedMovie)
        {
            InitializeComponent();
            this.selectedMovie = selectedMovie;
            MovieEntry.Text = selectedMovie.Title;
        }

        private void updateBtn_Clicked(object sender, EventArgs e)
        {
            selectedMovie.Title = MovieEntry.Text;
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Movie>();
                int rows = conn.Update(selectedMovie);
                
                if (rows > 0)
                {
                    DisplayAlert("Success", " Updated", "OK");
                }
                else
                {
                    DisplayAlert("Warning", " Not Updated", "OK");
                }
            }
        }

        private void deleteBtn_Clicked(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Movie>();
                int rows = conn.Delete(selectedMovie);
               
                if (rows > 0)
                {
                    DisplayAlert("Success", " Deleted", "OK");
                }
                else
                {
                    DisplayAlert("Warning", " Not Deleted", "OK");
                }
            }
        }
    }
}