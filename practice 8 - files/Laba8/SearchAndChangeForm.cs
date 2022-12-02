using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Laba8
{
    public partial class SearchAndChangeForm : Form
    {
        Student student = null;
        public SearchAndChangeForm()
        {
            InitializeComponent();
        }

        void Output(object person)
        {
            if (person == null)
                OutputTextBox.Text = "Ничего не найдено";
            else
            {
                student = (Student)person;
                OutputTextBox.Text = student.name + "   " + student.group + "  группа";
            }
        }

        private void KeySearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"(?i)[а-я]+");
            string name = SearchTextBox.Text;

            if (pattern.IsMatch(name))
                KeySearchBtn.Enabled = true;
            else KeySearchBtn.Enabled = false;
        }
        

        private void KeySearchBtn_Click(object sender, EventArgs e)
        {
            string key = SearchTextBox.Text;

            object person = Student.KeySearch(key);

            Output(person);
        }
        private void NumberSearchBtn_Click(object sender, EventArgs e)
        {
            int number = (int)GroupNUD.Value - 1;
            object person = Student.NumberSearch(number);

            Output(person);
        }
        private void EditEnabledBtn_Click(object sender, EventArgs e)
        {
            RewriteBtn.Visible = true;
            RewriteBtn.Enabled = true;
            DeleteBtn.Visible = true;
            DeleteBtn.Enabled = true;
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (student != null)
            {
                Student.DeleteStudent(student);
                OutputTextBox.Text = "Запись удалена";
                Student.Packing();
            }
            else OutputTextBox.Text = "Нет данных для удаления";
        }
        private void RewriteBtn_Click(object sender, EventArgs e)
        {
            RewriteNameTextBox.Visible = true;
            SaveChangesBtn.Visible = true;
            SaveChangesBtn.Enabled = true;
            try { RewriteNameTextBox.Text = student.name; }
            catch { RewriteNameTextBox.Text = "Нет данных для изменения"; }
        }
        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            if (student != null)
            {
                student.name = RewriteNameTextBox.Text;
                Student.CorrectInfo(student);
                Student.Packing();
                RewriteNameTextBox.Text = "Запись изменена";
            }
            else RewriteNameTextBox.Text = "Нет данных для изменения";
        }

        private void RewriteNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex pattern = new Regex(@"(?i)[а-я]+ (?i)[а-я]+ (?i)[а-я]+");
            string name = RewriteNameTextBox.Text;

            if (pattern.IsMatch(name))
                SaveChangesBtn.Enabled = true;
            else SaveChangesBtn.Enabled = false;

            if (OutputTextBox.Text == "")
                SaveChangesBtn.Enabled = false;
        }

        private void GroupNUD_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
