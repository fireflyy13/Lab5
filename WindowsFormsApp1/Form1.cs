using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private Dictionary<string, LinkedList<string>> birthdayTable = new Dictionary<string, LinkedList<string>>();
        private Dictionary<string, LinkedList<string>> HashValues = new Dictionary<string, LinkedList<string>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddByDivision(object sender, EventArgs e)
        {
            string name = textBoxSurname.Text;
            string birthday = birthdayTimePicker.Value.ToShortDateString();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введіть прізвище студентки!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (birthday == null)
            {
                MessageBox.Show("Введіть дату народження!", "Помилка", MessageBoxButtons.OK);
                return;
            }

            if (birthdayTimePicker.Value.Year < 1894 || birthdayTimePicker.Value.Year > 2006)
            {
                MessageBox.Show("Введіть дійсну дату народження!", "Помилка", MessageBoxButtons.OK);
                return;
            }

            AddStudentBirthday(birthday, name);
            string hash = DivisionMethod(name, birthdayTimePicker.Value.Date);
            if (!birthdayTable.ContainsKey(name) && !HashValues.ContainsKey(name))
            {
                LinkedList<string> hashList = new LinkedList<string>();
                hashList.AddLast(hash);
                HashValues.Add(name, hashList);
            }

            else
            {
                HashValues[name].AddLast(hash);
            }

            ListOfStudent.Items.Add($"Ім'я: {name}\t Датa: {birthday}\t Хеш: {hash}");
        }

        private void addByMultiplication(object sender, EventArgs e)
        {
            string name = textBoxSurname.Text;
            string birthday = birthdayTimePicker.Value.ToShortDateString();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введіть прізвище студентки!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (birthday == null)
            {
                MessageBox.Show("Введіть дату народження!", "Помилка", MessageBoxButtons.OK);
                return;
            }

            if (birthdayTimePicker.Value.Year < 1894 || birthdayTimePicker.Value.Year > 2006)
            {
                MessageBox.Show("Введіть дійсну дату народження!", "Помилка", MessageBoxButtons.OK);
                return;
            }

            AddStudentBirthday(birthday, name);
            string hash = MultiplicationMethod(name, birthdayTimePicker.Value.Date);
            if (!birthdayTable.ContainsKey(name) && !HashValues.ContainsKey(name))
            {
                LinkedList<string> hashList = new LinkedList<string>();
                hashList.AddLast(hash);
                HashValues.Add(name, hashList);
            }

            else
            {
                HashValues[name].AddLast(hash);
            }

            ListOfStudent.Items.Add($"Ім'я: {name}\t Датa: {birthday}\t Хеш: {hash}");
        }

        private void AddStudentBirthday(string birthday, string name)
        {
            if (!birthdayTable.ContainsKey(birthday))
            {
                LinkedList<string> namesList = new LinkedList<string>();
                namesList.AddLast(name);
                birthdayTable.Add(birthday, namesList);
            }

            birthdayTable[birthday].AddLast(name);
        }


        public string DivisionMethod(string name, DateTime birthdayTimePicker)
        {
            int M = 599;
            string hash = Math.Abs(((birthdayTimePicker.Day *
                birthdayTimePicker.Month * birthdayTimePicker.Year * name.GetHashCode()) % M)).ToString();
            return hash;
        }

        public string MultiplicationMethod(string name, DateTime birthdayTimePicker)
        {
            double A = 0.9;
            int M = 599;
            string hash = Math.Abs(Math.Floor(M * ((A * (name.GetHashCode() *
                birthdayTimePicker.Day * birthdayTimePicker.Month *
                birthdayTimePicker.Year)) % 1))).ToString();
            return hash;
        }


        private void deleteStudent(object sender, EventArgs e)
        {
            if (ListOfStudent.SelectedItems.Count == 0)
            {
                MessageBox.Show("Будь ласка, оберіть студентку для видалення!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem selectedItem = ListOfStudent.SelectedItems[0];
            string birthday = selectedItem.Text.Split(':')[1].Trim();
            string name = selectedItem.Text.Split(':')[0].Trim();

            if (birthdayTable.ContainsKey(birthday))
            {
                birthdayTable.Remove(birthday);
            }

            if (HashValues.ContainsKey(name))
            {
                HashValues.Remove(name);
            }

            ListOfStudent.Items.Remove(selectedItem);
        }

        private void showStudentByDate(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            string birthday = chooseDate.Value.ToShortDateString();

            if (!birthdayTable.ContainsKey(birthday))
            {
                MessageBox.Show($"Немає студенток, дата народження яких - {birthday}", "Помилка", MessageBoxButtons.OK);
                return;
            }

            foreach (var student in birthdayTable[birthday])
            {
                listView1.Items.Add(student);
            }
        }

        private void clearDateTable(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            textBox1.Clear();
        }
        private void showStudentByHash(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            string searchedHash = textBox1.Text;
            if (searchedHash == null)
            {
                MessageBox.Show("Введіть дату народження!", "Помилка", MessageBoxButtons.OK);
                return;
            }

            bool hashFound = false;

            foreach (var entry in HashValues)
            {
                if (entry.Value.Contains(searchedHash))
                {
                    listView2.Items.Add($"{entry.Key}");
                    hashFound = true;
                }
            }

            if (!hashFound)
            {
                MessageBox.Show("Не існує дати народження, якій відповідає введений хеш.",
                    "Помилка", MessageBoxButtons.OK);
            }

            textBox1.Clear();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void labelSurname_Click(object sender, EventArgs e)
        {

        }

        private void labelDateChoose_Click(object sender, EventArgs e)
        {

        }
    }
}
