using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Lab1
{
    public partial class Form1 : Form
    {

       const byte IntQstCount = 2;
       const byte QltQstCount = 4;
       static float[] Questions = new float[IntQstCount + QltQstCount];
       const int MaxScore = 16;
       static string[] ProblemsList = new string[IntQstCount + QltQstCount];

        public Form1()
        {
            InitializeComponent();
        }

        public double Result()
        {

            double InterfaceResult = 0;
            double QualityResult = 0;
            for (int i = 0; i < IntQstCount; i++)
                InterfaceResult += Questions[i];

            for (int i = IntQstCount; i < Questions.Length; i++)
                QualityResult += Questions[i];


            return InterfaceResult + QualityResult;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public string ArrayToString(string[] array)
        {
            string str = null;
            for (int i = 0; i < array.Length; i++)
            {
                str += array[i];
            }
            return str;
        }     


        private void bt_Done_Click(object sender, EventArgs e)
        {
            if (cbIsEmpty())
            {
                MessageBox.Show("Вы ввели не все данные!", "Ошибка");
                return;
            }

            if (Result() >= MaxScore * 0.75)
                MessageBox.Show("Требования заказчика удовлетворены", "Результат");
            else if (Result() >= MaxScore * 0.50)
                MessageBox.Show("Программе требуется частичная доработка.\nНеобходимо:\n" + ArrayToString(ProblemsList), "Результат");
            else
                MessageBox.Show("Программа нуждается в полной переработке!\nНеобходимо:\n" + ArrayToString(ProblemsList), "Результат");

        }

        private void cb_Q1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string caseSwitch = cb_Q1.Text;
            switch (caseSwitch)
            {
                case "Отлично":
                    Questions[0] = 3;
                    ProblemsList[0] = "";
                    break;
                case "Хорошо":
                    Questions[0] = 2;
                    ProblemsList[0] = "";
                    break;
                case "Удовлетворительно":
                    Questions[0] = 1;
                    ProblemsList[0] = "Оптимизировать скорость работы интерфейса\n";
                    break;
                case "Плохо":
                    Questions[0] = 0;
                    ProblemsList[0] = "Оптимизировать скорость работы интерфейса\n";
                    break;
                default:
                    Questions[0] = 0;
                    break;
            }
        }

        private void cb_Q2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string caseSwitch = cb_Q2.Text;
            switch (caseSwitch)
            {
                case "Отлично":
                    Questions[1] = 3;
                    ProblemsList[1] = "";
                    break;
                case "Хорошо":
                    Questions[1] = 2;
                    ProblemsList[1] = "";
                    break;
                case "Удовлетворительно":
                    Questions[1] = 1;
                    ProblemsList[1] = "Поработать над удобством интерфейса\n";
                    break;
                case "Плохо":
                    Questions[1] = 0;
                    ProblemsList[1] = "Поработать над удобством интерфейса\n";
                    break;
                default:
                    Questions[1] = 0;
                    break;
            }
        }

        private void cb_Qlt_Q1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string caseSwitch = cb_Qlt_Q1.Text;
            switch (caseSwitch)
            {
                case "Отлично":
                    Questions[2] = 3;
                    ProblemsList[2] = "";
                    break;
                case "Хорошо":
                    Questions[2] = 2;
                    ProblemsList[2] = "";
                    break;
                case "Удовлетворительно":
                    Questions[2] = 1;
                    ProblemsList[2] = "Оптимизировать скорость работы функций программы\n";
                    break;
                case "Плохо":
                    Questions[2] = 0;
                    ProblemsList[2] = "Оптимизировать скорость работы функций программы\n";
                    break;
                default:
                    Questions[2] = 0;
                    break;
            }
        }

        private void cb_Qlt_Q2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string caseSwitch = cb_Qlt_Q2.Text;
            switch (caseSwitch)
            {
                case "Совместима со многими старыми версиями ОС":
                    Questions[3] = 2;
                    ProblemsList[3] = "";
                    break;
                case "Совместима со свежими версиями ОС":
                    Questions[3] = 1;
                    ProblemsList[3] = "Поработать над совместимостью со старыми ОС\n";
                    break;
                case "Совместима только с текущей версией ОС":
                    Questions[3] = 0;
                    ProblemsList[3] = "Поработать над совместимостью со старыми ОС\n";
                    break;
                default:
                    Questions[3] = 0;
                    break;
            }
        }

        private void cb_Qlt_Q3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string caseSwitch = cb_Qlt_Q3.Text;
            switch (caseSwitch)
            {
                case "Отсутствуют":
                    Questions[4] = 3;
                    ProblemsList[4] = "";
                    break;
                case "Незначительно":
                    Questions[4] = 2;
                    ProblemsList[4] = "Исправить критические ошибки\n";
                    break;
                case "Много":
                    Questions[4] = 1;
                    ProblemsList[4] = "Исправить критические ошибки\n";
                    break;
                case "Критичное":
                    Questions[4] = 0;
                    ProblemsList[4] = "Исправить критические ошибки\n";
                    break;
                default:
                    Questions[4] = 0;
                    break;
            }
        }

        private void cb_Qlt_Q4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string caseSwitch = cb_Qlt_Q4.Text;
            switch (caseSwitch)
            {
                case "Сильная":
                    Questions[5] = 2;
                    break;
                case "Средняя ":
                    Questions[5] = 1;
                    break;
                case "Слабая":
                    Questions[5] = 0;
                    ProblemsList[5] = "Переработать систему безопастности программы\n";
                    break;
                default:
                    Questions[5] = 0;
                    break;
            }
        }

        public bool cbIsEmpty()
        {
            return (cb_Q1.SelectedIndex == -1)|| (cb_Q2.SelectedIndex == -1) || (cb_Qlt_Q1.SelectedIndex == -1) || (cb_Qlt_Q2.SelectedIndex == -1) 
                || (cb_Qlt_Q3.SelectedIndex == -1) || (cb_Qlt_Q4.SelectedIndex == -1);
        }
    }
}

