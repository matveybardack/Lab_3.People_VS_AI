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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsDeviders
{
    public partial class Task5UserControl5 : UserControl
    {
        public Task5UserControl5()
        {
            InitializeComponent();
        }

        private void buttonSearchTask2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (int.TryParse(textBoxN.Text, out int N) && N > 0)
            {
                var primeNumbers = ClassDividers.ProstDivEr(N);
                foreach (var prime in primeNumbers)
                {
                    listBox1.Items.Add(prime);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите натуральное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo5_Click(object sender, EventArgs e)
        {
            InfoForm1 infoForm1 = new InfoForm1(4);
            infoForm1.ShowDialog();
        }

    }
}
