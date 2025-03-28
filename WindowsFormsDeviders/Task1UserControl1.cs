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
                //Заполнение списка делителей
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
        // Вызов формы со справкой
        private void buttonInfo1_Click(object sender, EventArgs e)
        {
            InfoForm1 infoForm1 = new InfoForm1(0);
            infoForm1.ShowDialog();
        }
    }
}
