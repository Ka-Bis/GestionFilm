namespace GestionFilm
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonSendMovie = new System.Windows.Forms.Button();
            this.GroupBoxAddMovie = new System.Windows.Forms.GroupBox();
            this.TextBoxStudio = new System.Windows.Forms.TextBox();
            this.LabelStudio = new System.Windows.Forms.Label();
            this.TextBoxYear = new System.Windows.Forms.TextBox();
            this.LabelYear = new System.Windows.Forms.Label();
            this.TextBoxGenre = new System.Windows.Forms.TextBox();
            this.LabelGenre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelMovieName = new System.Windows.Forms.Label();
            this.GroupBoxAddMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSendMovie
            // 
            this.ButtonSendMovie.Location = new System.Drawing.Point(534, 317);
            this.ButtonSendMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSendMovie.Name = "ButtonSendMovie";
            this.ButtonSendMovie.Size = new System.Drawing.Size(112, 35);
            this.ButtonSendMovie.TabIndex = 3;
            this.ButtonSendMovie.Text = "Envoyer";
            this.ButtonSendMovie.UseVisualStyleBackColor = true;
            // 
            // GroupBoxAddMovie
            // 
            this.GroupBoxAddMovie.Controls.Add(this.TextBoxStudio);
            this.GroupBoxAddMovie.Controls.Add(this.LabelStudio);
            this.GroupBoxAddMovie.Controls.Add(this.TextBoxYear);
            this.GroupBoxAddMovie.Controls.Add(this.LabelYear);
            this.GroupBoxAddMovie.Controls.Add(this.TextBoxGenre);
            this.GroupBoxAddMovie.Controls.Add(this.LabelGenre);
            this.GroupBoxAddMovie.Controls.Add(this.textBox1);
            this.GroupBoxAddMovie.Controls.Add(this.LabelMovieName);
            this.GroupBoxAddMovie.Location = new System.Drawing.Point(70, 54);
            this.GroupBoxAddMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBoxAddMovie.Name = "GroupBoxAddMovie";
            this.GroupBoxAddMovie.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBoxAddMovie.Size = new System.Drawing.Size(576, 253);
            this.GroupBoxAddMovie.TabIndex = 2;
            this.GroupBoxAddMovie.TabStop = false;
            this.GroupBoxAddMovie.Text = "Ajouter un film";
            // 
            // TextBoxStudio
            // 
            this.TextBoxStudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxStudio.Location = new System.Drawing.Point(298, 169);
            this.TextBoxStudio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxStudio.Name = "TextBoxStudio";
            this.TextBoxStudio.Size = new System.Drawing.Size(235, 26);
            this.TextBoxStudio.TabIndex = 7;
            // 
            // LabelStudio
            // 
            this.LabelStudio.AutoSize = true;
            this.LabelStudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudio.Location = new System.Drawing.Point(298, 145);
            this.LabelStudio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelStudio.Name = "LabelStudio";
            this.LabelStudio.Size = new System.Drawing.Size(156, 20);
            this.LabelStudio.TabIndex = 6;
            this.LabelStudio.Text = "Studio de production";
            // 
            // TextBoxYear
            // 
            this.TextBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxYear.Location = new System.Drawing.Point(9, 169);
            this.TextBoxYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxYear.Name = "TextBoxYear";
            this.TextBoxYear.Size = new System.Drawing.Size(235, 26);
            this.TextBoxYear.TabIndex = 5;
            // 
            // LabelYear
            // 
            this.LabelYear.AutoSize = true;
            this.LabelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelYear.Location = new System.Drawing.Point(9, 145);
            this.LabelYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelYear.Name = "LabelYear";
            this.LabelYear.Size = new System.Drawing.Size(157, 20);
            this.LabelYear.TabIndex = 4;
            this.LabelYear.Text = "Année de production";
            // 
            // TextBoxGenre
            // 
            this.TextBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxGenre.Location = new System.Drawing.Point(298, 74);
            this.TextBoxGenre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxGenre.Name = "TextBoxGenre";
            this.TextBoxGenre.Size = new System.Drawing.Size(235, 26);
            this.TextBoxGenre.TabIndex = 3;
            // 
            // LabelGenre
            // 
            this.LabelGenre.AutoSize = true;
            this.LabelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGenre.Location = new System.Drawing.Point(298, 49);
            this.LabelGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelGenre.Name = "LabelGenre";
            this.LabelGenre.Size = new System.Drawing.Size(54, 20);
            this.LabelGenre.TabIndex = 2;
            this.LabelGenre.Text = "Genre";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(9, 74);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 26);
            this.textBox1.TabIndex = 1;
            // 
            // LabelMovieName
            // 
            this.LabelMovieName.AutoSize = true;
            this.LabelMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMovieName.Location = new System.Drawing.Point(9, 49);
            this.LabelMovieName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelMovieName.Name = "LabelMovieName";
            this.LabelMovieName.Size = new System.Drawing.Size(42, 20);
            this.LabelMovieName.TabIndex = 0;
            this.LabelMovieName.Text = "Nom";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.ButtonSendMovie);
            this.Controls.Add(this.GroupBoxAddMovie);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.GroupBoxAddMovie.ResumeLayout(false);
            this.GroupBoxAddMovie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSendMovie;
        private System.Windows.Forms.GroupBox GroupBoxAddMovie;
        private System.Windows.Forms.TextBox TextBoxStudio;
        private System.Windows.Forms.Label LabelStudio;
        private System.Windows.Forms.TextBox TextBoxYear;
        private System.Windows.Forms.Label LabelYear;
        private System.Windows.Forms.TextBox TextBoxGenre;
        private System.Windows.Forms.Label LabelGenre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabelMovieName;
    }

}