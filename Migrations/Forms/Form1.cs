using Migrations.Forms;

namespace Migrations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddTeacher addForm = new AddTeacher();
            addForm.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddSubject addForm = new AddSubject();
            addForm.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AddDepartament addForm = new AddDepartament();
            addForm.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AddFaculty addForm = new AddFaculty();
            addForm.ShowDialog();
        }
    }
}
