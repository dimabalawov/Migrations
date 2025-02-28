using Microsoft.EntityFrameworkCore;
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
    public partial class AddTeacher : Form
    {
        Teacher newTeacher = new Teacher();
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                newTeacher.Name = textBox1.Text;
                newTeacher.Surname = textBox2.Text;
                newTeacher.Salary = int.Parse(textBox3.Text);
                using (var db = new UniversityContext())
                {
                    db.Teachers.Add(newTeacher);
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
