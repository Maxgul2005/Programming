using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class MainForm : Form
    {
        private List<Student> students = new List<Student>();
        public MainForm()
        {
            InitializeComponent();
            // Заполняем ComboBox значениями для факультета и формы обучения
            facultyComboBox.DataSource = Enum.GetValues(typeof(Faculty));
            educationFormComboBox.DataSource = Enum.GetValues(typeof(EducationForm));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверяем введенные данные перед добавлением
            if (string.IsNullOrEmpty(fullNameTextBox.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int studentId;
            if (!int.TryParse(textBox2.Text, out studentId) || studentId < 100000 || studentId > 999999)
            {
                MessageBox.Show("Неверный номер зачетки (ID)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student student = new Student
            {
                FullName = fullNameTextBox.Text,
                StudentId = studentId,
                Group = textBox3.Text,
                Faculty = (Faculty)facultyComboBox.SelectedItem,
                EducationForm = (EducationForm)educationFormComboBox.SelectedItem
            };
            students.Add(student);
            UpdateStudentList();
            ClearFields();
        }

        private void UpdateStudentList()
        {
            // Сортируем студентов по полному имени перед отображением
            students.Sort((s1, s2) => s1.FullName.CompareTo(s2.FullName));

            // Очищаем список студентов и добавляем заново отсортированные записи
            listBox1.Items.Clear();
            foreach (var student in students)
            {
                listBox1.Items.Add($"{student.FullName} - {student.Group} / {student.Faculty}");
            }
        }

        private void ClearFields()
        {
            fullNameTextBox.Clear();
            textBox2.Clear();
            textBox3.Clear();
            facultyComboBox.SelectedIndex = 0;
            educationFormComboBox.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string origText = textBox1.Text;
            string CurrentText = "";
            foreach(char c in origText)
            {
                if (char.IsDigit(c))
                {
                    CurrentText += c;
                    
                }
            }
            textBox1.Text = CurrentText;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }

    public class Student
    {
        public string FullName { get; set; }
        public int StudentId { get; set; }
        public string Group { get; set; }
        public Faculty Faculty { get; set; }
        public EducationForm EducationForm { get; set; }
    }

    public enum Faculty
    {
        ComputerScience,
        Mathematics,
        Physics,
        Chemistry,
        Biology
    }

    public enum EducationForm
    {
        FullTime,
        PartTime,
        Correspondence
    }
}
