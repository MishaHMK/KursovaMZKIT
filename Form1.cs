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
            List = createPersonList();
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

            List<Person> list = new List<Person>();

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

        public List<Person> List = createPersonList();
        public List<Company> Companies = createCompamyList();

        bool desc = false;
        string name = "";

        public void addToList(Person person)
        {
            string path = "user.json";
            List.Add(person);
            writeJson(List, path);
            List = createPersonList();
            fillData();
        }

        public void TimSort(bool desc)
        {
            TimSort obj = new TimSort();

            int n = List.Count;

            if (desc == true)
            {
                obj.timSort(List, n);
            }
            else obj.timSort2(List, n);

            fillData();
        }

        public void GapSort(bool desc)
        {
            GapSort obj = new GapSort();

            if (desc == true)
            {
                obj.combSort(List, desc);
            }
            else
            {
                obj.combSort(List, desc);
            }

            fillData();
        }

        public void Filtering(int? company)
        {
            Filtering obj = new Filtering();

            List<Person> slist = List;

            List = obj.getFiltered(List, name, company);

            dataGridView1.Rows.Clear();

            foreach (Person elem in slist)
            {
                string companyName = Companies[elem.CompanyId - 1].Name;

                string[] row = { $"{elem.Id}", $"{elem.Name}", $"{elem.Surname}", $"{elem.BirthDate.ToString("d")}", $"{companyName.ToString()}" };

                dataGridView1.Rows.Add(row);
            }
        }

        private void fillData()
        {
            dataGridView1.Rows.Clear();

            foreach (Person elem in List)
            {

                string companyName = Companies[elem.CompanyId - 1].Name;

                string[] row = { $"{elem.Id}", $"{elem.Name}", $"{elem.Surname}", $"{elem.BirthDate.ToString("d")}", $"{companyName.ToString()}" };

                dataGridView1.Rows.Add(row);
            }
        }

        private void fillBtn_Click(object sender, EventArgs e)
        {
            List = createPersonList();
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

            List<Person> dlist = List;

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
                string companyName = Companies[elem.CompanyId - 1].Name;

                string[] row = { $"{elem.Id}", $"{elem.Name}", $"{elem.Surname}", $"{elem.BirthDate.ToString("d")}", $"{companyName}" };

                dataGridView1.Rows.Add(row);
            }
        }

        private void filteringBtn_Click_1(object sender, EventArgs e)
        {
            string c = comboBox1.Text;

            int id = Companies.Where(x => x.Name == c).Select(x => x.Id).FirstOrDefault();

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
            int id = Companies.Where(x => x.Name == c).Select(x => x.Id).FirstOrDefault();

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

        private void deletePerson(int id)
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

            List = createPersonList();
            fillData();

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
        private void gapBtn_Click(object sender, EventArgs e)
        {
            GapSort(desc);
        }

    }
}
