using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDeviders
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowTask(UserControl taskControl)
        {
            // Очищаем панель
            panelTaskContainer.Controls.Clear();

            // Настраиваем UserControl
            taskControl.Dock = DockStyle.Fill; // Растягиваем на всю панель
            taskControl.Visible = true;

            // Добавляем UserControl на панель
            panelTaskContainer.Controls.Add(taskControl);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelTaskContainer_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            var task1 = new Task1UserControl1(); // Создаем экземпляр UserControl для задачи 1
            ShowTask(task1); // Отображаем его на панели
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            var task2 = new Task2UserControl2(); // Создаем экземпляр UserControl для задачи 1
            ShowTask(task2); // Отображаем его на панели
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            var task3 = new Task3UserControl3(); // Создаем экземпляр UserControl для задачи 1
            ShowTask(task3); // Отображаем его на панели
        }

        private void buttonTask4_Click(object sender, EventArgs e)
        {
            var task4 = new Task4UserControl4(); // Создаем экземпляр UserControl для задачи 1
            ShowTask(task4); // Отображаем его на панели
        }

        private void buttonTask5_Click(object sender, EventArgs e)
        {
            var task5 = new Task5UserControl5(); // Создаем экземпляр UserControl для задачи 1
            ShowTask(task5); // Отображаем его на панели
        }

        private void buttonTask6_Click(object sender, EventArgs e)
        {
            var task6 = new Task6UserControl6(); // Создаем экземпляр UserControl для задачи 1
            ShowTask(task6); // Отображаем его на панели
        }

        private void buttonTask7_Click(object sender, EventArgs e)
        {
            var task7 = new Task7UserControl7(); // Создаем экземпляр UserControl для задачи 1
            ShowTask(task7); // Отображаем его на панели
        }
    }
}
    
    
    

