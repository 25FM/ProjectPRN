namespace Manage_Movie
{
    partial class CRUD_Movie
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.description = new System.Windows.Forms.TextBox();
            this.labe = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.producer = new System.Windows.Forms.ComboBox();
            this.genres = new System.Windows.Forms.ListBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.language = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(224, 161);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(199, 100);
            this.description.TabIndex = 25;
            // 
            // labe
            // 
            this.labe.AutoSize = true;
            this.labe.Location = new System.Drawing.Point(499, 88);
            this.labe.Name = "labe";
            this.labe.Size = new System.Drawing.Size(43, 15);
            this.labe.TabIndex = 24;
            this.labe.Text = "Genres";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(245, 429);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(120, 23);
            this.btn.TabIndex = 23;
            this.btn.UseVisualStyleBackColor = true;
            // 
            // producer
            // 
            this.producer.FormattingEnabled = true;
            this.producer.Location = new System.Drawing.Point(224, 354);
            this.producer.Name = "producer";
            this.producer.Size = new System.Drawing.Size(199, 23);
            this.producer.TabIndex = 22;
            // 
            // genres
            // 
            this.genres.FormattingEnabled = true;
            this.genres.ItemHeight = 15;
            this.genres.Location = new System.Drawing.Point(499, 123);
            this.genres.Name = "genres";
            this.genres.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.genres.Size = new System.Drawing.Size(97, 319);
            this.genres.TabIndex = 21;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(223, 105);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 23);
            this.date.TabIndex = 20;
            // 
            // language
            // 
            this.language.Location = new System.Drawing.Point(224, 291);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(199, 23);
            this.language.TabIndex = 19;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(223, 48);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(200, 23);
            this.title.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Producer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Language";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "ReleaseDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Title";
            // 
            // CRUD_Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 553);
            this.Controls.Add(this.description);
            this.Controls.Add(this.labe);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.producer);
            this.Controls.Add(this.genres);
            this.Controls.Add(this.date);
            this.Controls.Add(this.language);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CRUD_Movie";
            this.Text = "CRUD_Movie";
            this.Load += new System.EventHandler(this.CRUD_Movie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox description;
        private Label labe;
        private Button btn;
        private ComboBox producer;
        private ListBox genres;
        private DateTimePicker date;
        private TextBox language;
        private TextBox title;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}