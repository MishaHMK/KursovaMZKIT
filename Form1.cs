using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WinFormsApp1;

namespace Kursova
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);

            Controls.Add(dataGridView1);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            list = createPersonList();
            fillData();
        }

        public static void writeJson(List<Person> list, string path)
        {
            var jsonToWrite = JsonConvert.SerializeObject(list, Formatting.Indented);

            using (var writer = new StreamWriter(path))
            {
                writer.Write(jsonToWrite);
            }
        }
        private static List<Person> createPersonList()
        {
            List<Company> companies = createCompamyList();

            //Person obj = new Person(1, "Tom", "Henderson", new DateTime(1970, 8, 30), companies[0].Id);
            //Person obj2 = new Person(2, "Rob", "Stark", new DateTime(1990, 7, 20), companies[0].Id);
            //Person obj3 = new Person(3, "Anna", "Potts", new DateTime(1991, 1, 12), companies[1].Id);
            //Person obj4 = new Person(4, "Jeff", "Crabs", new DateTime(1984, 5, 14), companies[1].Id);
            //Person obj5 = new Person(5, "Bob", "Downey", new DateTime(1996, 3, 16), companies[0].Id);

            List<Person> list = new List<Person>();

            //list.Add(obj);
            //list.Add(obj2);
            //list.Add(obj3);
            //list.Add(obj4);
            //list.Add(obj5);

            string jsonString;
            string path = "user.json";
                
            using (StreamReader reader = new StreamReader(path))
            {
                jsonString = reader.ReadToEnd();

                list = System.Text.Json.JsonSerializer.Deserialize<List<Person>>(jsonString);
            }

            writeJson(list, path);

            return list;
        }

        private static List<Company> createCompamyList()
        {
            Company obj = new Company(1, "Microsoft");
            Company obj2 = new Company(2, "Apple");

            List<Company> companyList = new List<Company>();

            companyList.Add(obj);
            companyList.Add(obj2);

            return companyList;
        }

        public static List<Person> list = createPersonList();
        public static List<Company> companies = createCompamyList();

        bool desc = false;
        string name = "";

        public static void addToList(Person person)
        {
            string path = "user.json";
            list.Add(person);
            writeJson(list, path);
        }

        public void TimSort(bool desc)
        {
            int n = list.Count;

            TimSort obj = new TimSort();

            if (desc == true)
            {
                obj.timSort(list, n);
            }
            else obj.timSort2(list, n);

            fillData();
        }


        public void GapSort(bool desc)
        {
            GapSort obj = new GapSort();

            if (desc == true)
            {
                obj.combSortDesc(list);
            }
            else obj.combSortAsc(list);

            fillData();
        }

        public void Filtering(int? company)
        {
            Filtering obj = new Filtering();

            List<Person> slist = list;

            slist = obj.getFiltered(list, name, company);

            dataGridView1.Rows.Clear();

            foreach (Person elem in slist)
            {
                string companyName = companies[elem.CompanyId - 1].Name;

                string[] row = { $"{elem.Id}", $"{elem.Name}", $"{elem.Surname}", $"{elem.BirthDate.ToString("d")}", $"{companyName.ToString()}" };

                dataGridView1.Rows.Add(row);
            }
        }

        private void fillData()
        {
            dataGridView1.Rows.Clear();

            foreach (Person elem in list)
            {

                string companyName = companies[elem.CompanyId - 1].Name;

                string[] row = { $"{elem.Id}", $"{elem.Name}", $"{elem.Surname}", $"{elem.BirthDate.ToString("d")}", $"{companyName.ToString()}" };

                dataGridView1.Rows.Add(row);
            }
        }

        private void gapBtn_Click(object sender, EventArgs e)
        {
            GapSort(desc);
        }

        private void fillBtn_Click(object sender, EventArgs e)
        {
            list = createPersonList();
            fillData();
        }

        private void sortBtn_Click_1(object sender, EventArgs e)
        {
            TimSort(desc);
        }

        private void gapBtn_Click_1(object sender, EventArgs e)
        {
            GapSort(desc);
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void filterYear_Click_1(object sender, EventArgs e)
        {
            Filtering obj = new Filtering();

            int value = Convert.ToInt32(numYear.Value);

            List<Person> dlist = list;

            List<Person> slist = new List<Person>();

            Person p = new Person();

            int c = 0;

            while (c < dlist.Count)
            {
                p = obj.getFibonnaci(dlist, dlist.Count, value);

                if (!String.IsNullOrEmpty(p.Name))
                {
                    slist.Add(p);

                    dlist.Remove(p);
                }
                c++;
            }

            dataGridView1.Rows.Clear();

            foreach (Person elem in slist)
            {
                string companyName = companies[elem.CompanyId - 1].Name;

                string[] row = { $"{elem.Id}", $"{elem.Name}", $"{elem.Surname}", $"{elem.BirthDate.ToString("d")}", $"{companyName}" };

                dataGridView1.Rows.Add(row);
            }
        }

        private void filteringBtn_Click_1(object sender, EventArgs e)
        {
            string c = comboBox1.Text;

            int id = companies.Where(x => x.Name == c).Select(x => x.Id).FirstOrDefault();

            if (String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(comboBox1.Text))
            {
                return;
            }
            else if (String.IsNullOrEmpty(comboBox1.Text))
            {
                Filtering(0);
            }
            else Filtering(id);
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                desc = true;
            }
            else desc = false;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string c = comboBox1.Text;
            int id = companies.Where(x => x.Name == c).Select(x => x.Id).FirstOrDefault();

            if (comboBox1.Text == "Any")
            {
                Filtering(0);
            }
            else
            {
                Filtering(id);
            }
        }

        private void addBtn_Click_2(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numId.Value);
            deletePerson(id);
        }

        private static void deletePerson(int id)
        {
            List<Person> list = new List<Person>();

            string jsonString;
            string path = "user.json";

            using (StreamReader reader = new StreamReader(path))
            {
                jsonString = reader.ReadToEnd();

                list = System.Text.Json.JsonSerializer.Deserialize<List<Person>>(jsonString);
            }

            var match = list.FirstOrDefault(c => c.Id == id);

            list.Remove(match);

            writeJson(list, path);
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void filteringBtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            form2.Show();
            string results = form2.GetData();
        }

        private void filterYear_Click(object sender, EventArgs e)
        {

        }

        private void numId_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
