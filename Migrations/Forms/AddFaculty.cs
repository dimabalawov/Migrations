using Migrations.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Migrations.Forms
{
    public partial class AddFaculty : Form
    {
        Faculty newFac = new Faculty();
        public AddFaculty()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox2.Text == null)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                newFac.Name = textBox2.Text;
                newFac.Financing = Int32.Parse(textBox1.Text);
                using (var db = new UniversityContext())
                {
                    db.Faculties.Add(newFac);
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
