using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Laba8
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        void DefineInputType(Student newStudent)
        {
            if (RadioBtn1.Checked)
                Student.AddToBeginning(newStudent);
            else if (RadioBtn2.Checked)
                Student.AddToEnd(newStudent);
            else
            {
                int position = (int)StudentNumberNUD.Value - 1;
                Student.AddToPosition(newStudent, position);
            }

        }

        private void AcceptNewStudentBtn_Click(object sender, EventArgs e)
        {
            string name = NameInputTextBox.Text;
            int group = (int)GroupInputNUD.Value;

            Student newStudent = new Student(name, group);
            DefineInputType(newStudent);

            NameInputTextBox.Text = "Запись добавлена";
        }

        private void NameInputTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"(?i)[а-я]+ (?i)[а-я]+ (?i)[а-я]+");
            string name = NameInputTextBox.Text;

            if (pattern.IsMatch(name))
                AcceptNewStudentBtn.Enabled = true;
            else AcceptNewStudentBtn.Enabled = false;
        }

        private void AddStudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Student.Packing();
        }

        private void RadioBtn3_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBtn3.Checked)
            {
                label4.Visible = true;
                StudentNumberNUD.Visible = true;
            }
            else
            {
                label4.Visible = false;
                StudentNumberNUD.Visible = false;
            }
        }
    }   
}
