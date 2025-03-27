using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryDividers;

namespace WindowsFormsDeviders
{
    public partial class Task1UserControl1 : UserControl
    {
        public Task1UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearchTask1_Click(object sender, EventArgs e)
        {
            listBox1Dividers.Items.Clear();
            if (int .TryParse(textBox1.Text, out int number))
            {
                if (number < 1)
                {
                    MessageBox.Show("Пожалуйста, введите натуральное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var dividers = ClassDividers.Dividers(number);
                var sortDivaiders = dividers.OrderBy(x => x);
                foreach (var divider in sortDivaiders)
                {
                    listBox1Dividers.Items.Add(divider);
                }   
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите натуральное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Task1UserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1Dividers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonInfo1_Click(object sender, EventArgs e)
        {
            InfoForm1 infoForm1 = new InfoForm1();
            infoForm1.ShowDialog();
        }
    }
}
