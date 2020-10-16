namespace GestionFilm
{
    partial class Form3
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
            this.ButtonSendPerson = new System.Windows.Forms.Button();
            this.GroupBoxAddPerson = new System.Windows.Forms.GroupBox();
            this.TextBoxBirth = new System.Windows.Forms.TextBox();
            this.CheckBoxProduc = new System.Windows.Forms.CheckBox();
            this.CheckBoxReal = new System.Windows.Forms.CheckBox();
            this.CheckBoxActor = new System.Windows.Forms.CheckBox();
            this.TextBoxNationnality = new System.Windows.Forms.TextBox();
            this.LabelNationality = new System.Windows.Forms.Label();
            this.LabelBirth = new System.Windows.Forms.Label();
            this.TextBoxFstName = new System.Windows.Forms.TextBox();
            this.LabelFstName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.GroupBoxAddPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSendPerson
            // 
            this.ButtonSendPerson.Location = new System.Drawing.Point(521, 291);
            this.ButtonSendPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSendPerson.Name = "ButtonSendPerson";
            this.ButtonSendPerson.Size = new System.Drawing.Size(112, 35);
            this.ButtonSendPerson.TabIndex = 5;
            this.ButtonSendPerson.Text = "Envoyer";
            this.ButtonSendPerson.UseVisualStyleBackColor = true;
            this.ButtonSendPerson.Click += new System.EventHandler(this.ButtonSendPerson_Click);
            // 
            // GroupBoxAddPerson
            // 
            this.GroupBoxAddPerson.Controls.Add(this.TextBoxBirth);
            this.GroupBoxAddPerson.Controls.Add(this.CheckBoxProduc);
            this.GroupBoxAddPerson.Controls.Add(this.CheckBoxReal);
            this.GroupBoxAddPerson.Controls.Add(this.CheckBoxActor);
            this.GroupBoxAddPerson.Controls.Add(this.TextBoxNationnality);
            this.GroupBoxAddPerson.Controls.Add(this.LabelNationality);
            this.GroupBoxAddPerson.Controls.Add(this.LabelBirth);
            this.GroupBoxAddPerson.Controls.Add(this.TextBoxFstName);
            this.GroupBoxAddPerson.Controls.Add(this.LabelFstName);
            this.GroupBoxAddPerson.Controls.Add(this.TextBoxName);
            this.GroupBoxAddPerson.Controls.Add(this.LabelName);
            this.GroupBoxAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxAddPerson.Location = new System.Drawing.Point(109, 26);
            this.GroupBoxAddPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBoxAddPerson.Name = "GroupBoxAddPerson";
            this.GroupBoxAddPerson.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBoxAddPerson.Size = new System.Drawing.Size(524, 240);
            this.GroupBoxAddPerson.TabIndex = 4;
            this.GroupBoxAddPerson.TabStop = false;
            this.GroupBoxAddPerson.Text = "Ajouter une personnalité";
            // 
            // TextBoxBirth
            // 
            this.TextBoxBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBirth.Location = new System.Drawing.Point(9, 158);
            this.TextBoxBirth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxBirth.Name = "TextBoxBirth";
            this.TextBoxBirth.Size = new System.Drawing.Size(151, 26);
            this.TextBoxBirth.TabIndex = 12;
            // 
            // CheckBoxProduc
            // 
            this.CheckBoxProduc.AutoSize = true;
            this.CheckBoxProduc.Location = new System.Drawing.Point(402, 160);
            this.CheckBoxProduc.Name = "CheckBoxProduc";
            this.CheckBoxProduc.Size = new System.Drawing.Size(106, 24);
            this.CheckBoxProduc.TabIndex = 11;
            this.CheckBoxProduc.Text = "Producteur";
            this.CheckBoxProduc.UseVisualStyleBackColor = true;
            // 
            // CheckBoxReal
            // 
            this.CheckBoxReal.AutoSize = true;
            this.CheckBoxReal.Location = new System.Drawing.Point(287, 160);
            this.CheckBoxReal.Name = "CheckBoxReal";
            this.CheckBoxReal.Size = new System.Drawing.Size(109, 24);
            this.CheckBoxReal.TabIndex = 10;
            this.CheckBoxReal.Text = "Réalisateur";
            this.CheckBoxReal.UseVisualStyleBackColor = true;
            // 
            // CheckBoxActor
            // 
            this.CheckBoxActor.AutoSize = true;
            this.CheckBoxActor.Location = new System.Drawing.Point(206, 158);
            this.CheckBoxActor.Name = "CheckBoxActor";
            this.CheckBoxActor.Size = new System.Drawing.Size(75, 24);
            this.CheckBoxActor.TabIndex = 9;
            this.CheckBoxActor.Text = "Acteur";
            this.CheckBoxActor.UseVisualStyleBackColor = true;
            // 
            // TextBoxNationnality
            // 
            this.TextBoxNationnality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNationnality.Location = new System.Drawing.Point(327, 74);
            this.TextBoxNationnality.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxNationnality.Name = "TextBoxNationnality";
            this.TextBoxNationnality.Size = new System.Drawing.Size(151, 26);
            this.TextBoxNationnality.TabIndex = 7;
            // 
            // LabelNationality
            // 
            this.LabelNationality.AutoSize = true;
            this.LabelNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNationality.Location = new System.Drawing.Point(322, 49);
            this.LabelNationality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNationality.Name = "LabelNationality";
            this.LabelNationality.Size = new System.Drawing.Size(93, 20);
            this.LabelNationality.TabIndex = 6;
            this.LabelNationality.Text = "Nationnalité";
            // 
            // LabelBirth
            // 
            this.LabelBirth.AutoSize = true;
            this.LabelBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBirth.Location = new System.Drawing.Point(8, 133);
            this.LabelBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelBirth.Name = "LabelBirth";
            this.LabelBirth.Size = new System.Drawing.Size(142, 20);
            this.LabelBirth.TabIndex = 4;
            this.LabelBirth.Text = "Date de naissance";
            // 
            // TextBoxFstName
            // 
            this.TextBoxFstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFstName.Location = new System.Drawing.Point(168, 74);
            this.TextBoxFstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxFstName.Name = "TextBoxFstName";
            this.TextBoxFstName.Size = new System.Drawing.Size(151, 26);
            this.TextBoxFstName.TabIndex = 3;
            // 
            // LabelFstName
            // 
            this.LabelFstName.AutoSize = true;
            this.LabelFstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFstName.Location = new System.Drawing.Point(164, 49);
            this.LabelFstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFstName.Name = "LabelFstName";
            this.LabelFstName.Size = new System.Drawing.Size(64, 20);
            this.LabelFstName.TabIndex = 2;
            this.LabelFstName.Text = "Prénom";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(9, 74);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(151, 26);
            this.TextBoxName.TabIndex = 1;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.Location = new System.Drawing.Point(9, 49);
            this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(42, 20);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Nom";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonSendPerson);
            this.Controls.Add(this.GroupBoxAddPerson);
            this.Name = "Form3";
            this.Text = "Form3";
            this.GroupBoxAddPerson.ResumeLayout(false);
            this.GroupBoxAddPerson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSendPerson;
        private System.Windows.Forms.GroupBox GroupBoxAddPerson;
        private System.Windows.Forms.TextBox TextBoxNationnality;
        private System.Windows.Forms.Label LabelNationality;
        private System.Windows.Forms.Label LabelBirth;
        private System.Windows.Forms.TextBox TextBoxFstName;
        private System.Windows.Forms.Label LabelFstName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.CheckBox CheckBoxActor;
        private System.Windows.Forms.CheckBox CheckBoxReal;
        private System.Windows.Forms.CheckBox CheckBoxProduc;
        private System.Windows.Forms.TextBox TextBoxBirth;
    }
}