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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var isci1 = new Isciler("qasim", "memmedov", "qasim@", 9, 18 );
            Database.isciler.Add(isci1);
            var isci2 = new Isciler("hesen", "imanov", "imanov@", 10, 18);
            Database.isciler.Add(isci2);
            var isci3 = new Isciler("xeyyam", "serifzade", "xeyyam@", 9, 19);
            Database.isciler.Add(isci3);
            var isci4 = new Isciler("mustafa", "eminov", "mustafa@", 14, 18);
            Database.isciler.Add(isci4);
            var isci5 = new Isciler("perviz", "aliyev", "perviz@", 7, 18);
            Database.isciler.Add(isci5);
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btnMaawOrta_Click(object sender, EventArgs e)
        {
            int orta = 0;
            int say = 0;
            foreach (var item in Database.isciler)
            {
                orta += item.Maaw;
                say++;
            }

            orta = orta / say;
            MessageBox.Show("Ortalama Maaw : " + orta);

              }

        private void btnEnCoxIwci_Click(object sender, EventArgs e)
        {
            int max = 0;
            string ad = "";
            string soyad = "";
            foreach (var item in Database.isciler)
            {
                if (max < (item.Maaw / 100))
                {
                    ad = item.Name;
                    soyad = item.Surname;
                }
            }
            MessageBox.Show("en cox iwleyen iwci " + ad + " " + soyad);
        }

        private void btnMaasOrtaBoyuk_Click(object sender, EventArgs e)
        {
            List<Isciler> yeni = new List<Isciler>();
            int orta = 0;
            int say = 0;
            foreach (var item in Database.isciler)
            {
                orta += item.Maaw;
                say++;
            }

            orta = orta / say;
            foreach (var item in Database.isciler)
            {
                if(item.Maaw > orta)
                {
                    yeni.Add(item);
                }

            }

            var bindingsource1 = new BindingSource();
            bindingsource1.DataSource = yeni;
            data.DataSource = bindingsource1;
        }

        private void btnSaatCox_Click(object sender, EventArgs e)
        {
            List<Isciler> iwsaat = new List<Isciler>();
            foreach (var item in Database.isciler)
            {
                if (((item.Maaw) / 100) * 5 > 30)
                {
                    iwsaat.Add(item);
                }

            }
            var bindingsource1 = new BindingSource();
            bindingsource1.DataSource = iwsaat;
            data.DataSource = bindingsource1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         data.DataSource = Database.isciler;
            data.AutoResizeColumns();
        }

        private void data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int selectedid = Convert.ToInt32(data.Rows[data.CurrentCell.RowIndex].Cells[0].Value);

            MessageBox.Show("deyiwikliyi yerine yetirek");
                foreach (var user in Database.isciler)
                {
                    if (user.Id == selectedid)
                    {
                    user.GelmeVaxti =Convert.ToInt32(data.Rows[data.CurrentCell.RowIndex].Cells[4].Value);
                    user.Maaw = (user.GetmeVaxti - user.GelmeVaxti)*100;
                    user.GetmeVaxti = Convert.ToInt32(data.Rows[data.CurrentCell.RowIndex].Cells[5].Value);
                    user.Maaw = (user.GetmeVaxti - user.GelmeVaxti) * 100;
                }
                }

            var bindingsource1 = new BindingSource();
            bindingsource1.DataSource = Database.isciler;
            data.DataSource = bindingsource1;


            
        }

        private void btnIsciElave_Click(object sender, EventArgs e)
        {
            var AddWork = new AddWork();
            AddWork.Show();
        }
    }
}
