using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionFilm
{
    public partial class FormManageMovie : Form
    {
        public FormManageMovie()
        {
            InitializeComponent();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            FormAddMovie form2 = new FormAddMovie();
            form2.Show();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            FormAddPersonnality form3 = new FormAddPersonnality();
            form3.Show();
        }
    }
}
