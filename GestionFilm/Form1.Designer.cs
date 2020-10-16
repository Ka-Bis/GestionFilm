namespace GestionFilm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonAddMovie = new System.Windows.Forms.Button();
            this.ButtonAddPersonnality = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(655, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // ButtonAddMovie
            // 
            this.ButtonAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddMovie.Location = new System.Drawing.Point(63, 99);
            this.ButtonAddMovie.Name = "ButtonAddMovie";
            this.ButtonAddMovie.Size = new System.Drawing.Size(130, 29);
            this.ButtonAddMovie.TabIndex = 1;
            this.ButtonAddMovie.Text = "Ajouter un film";
            this.ButtonAddMovie.UseVisualStyleBackColor = true;
            // 
            // ButtonAddPersonnality
            // 
            this.ButtonAddPersonnality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddPersonnality.Location = new System.Drawing.Point(238, 99);
            this.ButtonAddPersonnality.Name = "ButtonAddPersonnality";
            this.ButtonAddPersonnality.Size = new System.Drawing.Size(194, 29);
            this.ButtonAddPersonnality.TabIndex = 2;
            this.ButtonAddPersonnality.Text = "Ajouter une personnalité";
            this.ButtonAddPersonnality.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonAddPersonnality);
            this.Controls.Add(this.ButtonAddMovie);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonAddMovie;
        private System.Windows.Forms.Button ButtonAddPersonnality;
    }
}

