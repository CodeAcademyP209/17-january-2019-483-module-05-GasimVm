using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCompany
{
    public partial class AddWork : Form
    {
        public AddWork()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {

        }
      static int id = 6;
        private void btnYaddaSaxla_Click(object sender, EventArgs e)
        {
            var add = new AddWork();
          string  Name = txtName.Text;
            string Surname = txtSurname.Text;
           DateTime time = DateTime.Now;
           string Email = txtEmail.Text;
           int GelmeVaxti =Convert.ToInt32( txtGelme.Text);
           int CixmaVaxti = Convert.ToInt32(txtCixma.Text);
            int Maaw = (CixmaVaxti - GelmeVaxti) * 100;
            int Id = id;
            id++;
           
            var yeniIsci = new Isciler(Name, Surname, Email, GelmeVaxti, CixmaVaxti);
            Database.isciler.Add(yeniIsci);
            this.Hide(); 
            MessageBox.Show("yeni isci evale olundu");
         

        }

        private void txtGelme_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGetme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
