using Microsoft.EntityFrameworkCore;
using Q1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Manage_Movie
{
    public partial class List_Movie : Form
    {
        private readonly PePrnFall22B1Context context = new();

        public List_Movie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void List_Movie_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void LoadDB()
        {

            dataGridView1.DataSource = context.Movies.Include("Genres").Include("Director").Select(x => new
            {
                x.Id,
                x.Title,
                x.ReleaseDate,
                x.Description,
                x.Language,
                x.Producer,
                x.Director.FullName,
                Genres = string.Join("\n", x.Genres.Select(g => g.Title))
            }).ToList();
            dataGridView1.Columns["ID"].Width = 30;
            dataGridView1.Columns["Description"].Width = 250;
            dataGridView1.Columns["FullName"].HeaderText = "Director";
            dataGridView1.Columns["Genres"].HeaderText = "Genres";
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD_Movie crud = new CRUD_Movie("add");
            crud.Show();
        }
        private void updateMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            var id = dataGridView1.Rows[rowindex].Cells["Id"].Value.ToString();

            string title = dataGridView1.Rows[rowindex].Cells["Title"].Value.ToString();
            MessageBox.Show(title);

            var releaseDate = dataGridView1.Rows[rowindex].Cells["ReleaseDate"].Value.ToString();

            if (dataGridView1.Rows[rowindex].Cells["Description"].Value.ToString() == null)
            {
                string description = "";
            }
            else { string description = dataGridView1.Rows[rowindex].Cells["Description"].Value.ToString(); }
            string language = dataGridView1.Rows[rowindex].Cells["Language"].Value.ToString();
            string producer = dataGridView1.Rows[rowindex].Cells["Producer"].Value.ToString();
            var director = dataGridView1.Rows[rowindex].Cells["Director"].Value.ToString();
            MessageBox.Show(director);

            //CRUD_Movie crud = new CRUD_Movie("update");
            //crud.Show();
        }

        private void watchMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WatchMovie.WatchMovie watchMovie = new WatchMovie.WatchMovie();
            watchMovie.Show();
        }

        private async void deleteMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to delete this movie?", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                int id = int.Parse(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
                Movie movie = context.Movies.Where(x => x.Id == id).FirstOrDefault();
                if (movie != null)
                {
                    context.Remove(movie);
                    await context.SaveChangesAsync();
                    LoadDB();
                }
            }
        }

        private void viewInWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

    }
}
