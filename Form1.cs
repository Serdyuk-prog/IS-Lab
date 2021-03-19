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
       float[] Questions = new float[IntQstCount + QltQstCount];
       const int MaxScore = 16;




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

        private void bt_Done_Click(object sender, EventArgs e)
        {
            if (Result() >= MaxScore * 0.75)
                MessageBox.Show("Требования заказчика удовлетворены", "Результат");
            else if (Result() >= MaxScore * 0.50)
                MessageBox.Show("Программе требуется частичная доработка", "Результат");
            else
                MessageBox.Show("Программа нуждается в полной переработке", "Результат");

        }

        private void cb_Q1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string caseSwitch = cb_Q1.Text;
            switch (caseSwitch)
            {
                case "Отлично":
                    Questions[0] = 3;                        
                    break;
                case "Хорошо":
                    Questions[0] = 2; 
                    break;
                case "Удовлетворительно":
                    Questions[0] = 1;
                    break;
                case "Плохо":
                    Questions[0] = 0;
                    break;
                default:
                    Questions[0] = 0;
                    break;
            }
//            lb_Done.Text = Questions[0].ToString();
        }

        private void cb_Q2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string caseSwitch = cb_Q2.Text;
            switch (caseSwitch)
            {
                case "Отлично":
                    Questions[1] = 3;
                    break;
                case "Хорошо":
                    Questions[1] = 2;
                    break;
                case "Удовлетворительно":
                    Questions[1] = 1;
                    break;
                case "Плохо":
                    Questions[1] = 0;
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
                    break;
                case "Хорошо":
                    Questions[2] = 2;
                    break;
                case "Удовлетворительно":
                    Questions[2] = 1;
                    break;
                case "Плохо":
                    Questions[2] = 0;
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
                    break;
                case "Совместима со свежими версиями ОС":
                    Questions[3] = 1;
                    break;
                case "Совместима только с текущей версией ОС":
                    Questions[3] = 0;
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
                    break;
                case "Незначительно":
                    Questions[4] = 2;
                    break;
                case "Много":
                    Questions[4] = 1;
                    break;
                case "Критичное":
                    Questions[4] = 0;
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
                    break;
                default:
                    Questions[5] = 0;
                    break;
            }
        }
    }
}

