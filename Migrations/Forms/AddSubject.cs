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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Migrations.Forms
{
    public partial class AddSubject : Form
    {
        Subject newSub = new Subject();
        public AddSubject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                newSub.Name = textBox1.Text;
                using (var db = new UniversityContext())
                {
                    db.Subjects.Add(newSub);
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
