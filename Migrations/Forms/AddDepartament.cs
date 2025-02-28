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
    public partial class AddDepartament : Form
    {
        Department newDep = new Department();
        public AddDepartament()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                newDep.Name = textBox2.Text;
                newDep.Financing = Int32.Parse(textBox1.Text);
                using (var db = new UniversityContext())
                {
                    int facultyId = db.Faculties
                    .Where(f => f.Name == textBox3.Text)
                    .Select(f => f.Id)
                    .FirstOrDefault();
                    newDep.FacultyId = facultyId;
                    db.Departments.Add(newDep);
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
