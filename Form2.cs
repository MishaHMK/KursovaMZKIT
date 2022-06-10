using Kursova;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 nform1)
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);
            form1 = nform1;
            form1.Hide();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //stops for from closing
            e.Cancel = true;
            this.Hide();
        }
        public string GetData()
        {
            return "The quick brown fox jumped over the lazy dog";
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(idBox.Text);
            string name = nameBox.Text;
            string sur = surBox.Text;
            DateTime dt = datePick.Value.Date;
            int company = Int32.Parse(cBox.Text);

            var match = form1.List.Where(c => c.Id == id);

            if (id != null && string.IsNullOrEmpty(name) == false &&
                string.IsNullOrEmpty(sur) == false && dt != DateTime.MinValue
                && company != null)
            {
                Person p = new Person(id, name, sur, dt, company);
                form1.addToList(p);
            }
            
        }
    }
}
