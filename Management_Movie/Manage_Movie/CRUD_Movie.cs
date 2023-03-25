using Microsoft.IdentityModel.Tokens;
using Q1.Models;

namespace Manage_Movie
{
    public partial class CRUD_Movie : Form
    {
        private readonly PePrnFall22B1Context context = new();
        private string str;
        public CRUD_Movie(string str)
        {
            InitializeComponent();
            this.str = str;
        }
        private void CRUD_Movie_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            if (str.Equals("add"))
            {
                this.Text = "Add Movie";
                btn.Text = "Add Movie";
            }
            else if (str.Equals("update"))
            {
                this.Text = "Update Movie";
                btn.Text = "Update Movie";
            }
            LoadDB(str);
        }

        private void LoadDB(string str)
        {
            producer.DataSource = context.Producers.ToList();
            genres.DataSource = context.Genres.ToList();
        }



        private void btn_Click(object sender, EventArgs e)
        {
            if (str.Equals("add"))
            {
                Producer pro = (Producer)producer.SelectedItem;
                var selectedGenres = new List<Genre>();

                foreach (var selectedItem in genres.SelectedItems)
                {
                    var genre = (Genre)selectedItem;
                    selectedGenres.Add(genre);
                }

                if (title.Text.IsNullOrEmpty() || description.Text.IsNullOrEmpty() || language.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("You need input all information before add new movie");
                    return;
                }
                Movie movie = new()
                {
                    Title = title.Text,
                    ReleaseDate = date.Value,
                    Description = description.Text,
                    Language = language.Text,
                    Producer = (Producer)producer.SelectedItem,
                    Genres = selectedGenres
                };
                context.Add(movie);
                context.SaveChanges();
                MessageBox.Show("Add new movie successfully");
            }
            else if (str.Equals("update"))
            {

            }
        }

    }
}