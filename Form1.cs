using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace IS_Lab1
{
    public partial class Form1 : Form
    {

       private List<Question> QuestionsList = new List<Question>();
       private List<string> ProblemsList = new List<string>();
       private double MaxScore;

        public Form1()
        {
            InitializeComponent();
        }

        public double Result()
        {
            double Total = 0;

            for (int i = 0; i < QuestionsList.Count; i++)            
                Total += QuestionsList[i].Answers[QuestionsList[i].cb.Text];       

            return Total;
        }

        private double CalculateMaxScore()
        {
            double score = 0;
            for (int i = 0; i < QuestionsList.Count; i++)
                score += QuestionsList[i].MaxScore;

            return score;
        }

        private void SetProblemsList()
        {

            for (int i = 0; i < QuestionsList.Count; i++)
            {
                double currentScore = (QuestionsList[i].Answers[QuestionsList[i].cb.Text]);
                if (currentScore < QuestionsList[i].MaxScore - 1)
                    ProblemsList.Add(QuestionsList[i].ErrorMessage);
            }

        }


        private void bt_Done_Click(object sender, EventArgs e)
        {
            ProblemsList.Clear();
            SetProblemsList();

            if (cbIsEmpty())
            {
                MessageBox.Show("Вы ввели не все данные!", "Ошибка");
                return;
            }


            if (Result() >= MaxScore * 0.75)
                MessageBox.Show("Требования заказчика удовлетворены", "Результат");
            else if (Result() >= MaxScore * 0.50)
                MessageBox.Show("Программе требуется частичная доработка.\nНеобходимо:\n" + String.Join(",\n", ProblemsList.ToArray() + "."));
            else
                MessageBox.Show("Программа нуждается в полной переработке!\nНеобходимо:\n" + String.Join(",\n", ProblemsList.ToArray() + "."));

        }


        public bool cbIsEmpty()
        {
            for (int i = 0; i < QuestionsList.Count; i++)
            {
                if (QuestionsList[i].cb.SelectedIndex == -1)
                    return true;
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            int i = 1;
            string CurrentFile = "Questions/UI/Question" + i.ToString() + ".json";
            while (File.Exists(CurrentFile))
            {
                QuestionsList.Add(new Question(CurrentFile, tableLayoutPanel1));
                i++;
                CurrentFile = "Questions/UI/Question" + i.ToString() + ".json";
            }

            float ratio = 100F/ i;
            for (int j = 0; j < i; j++)
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, ratio));
            

            i = 1;
            CurrentFile = "Questions/Quality/Question" + i.ToString() + ".json";
            while (File.Exists(CurrentFile))
            {
                QuestionsList.Add(new Question(CurrentFile, tableLayoutPanel2));
                i++;
                CurrentFile = "Questions/Quality/Question" + i.ToString() + ".json";
            }

            ratio = 100F / i;
            for (int j = 0; j < i; j++)
                tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, ratio));
            

            i = 1;
            CurrentFile = "Questions/Customer/Question" + i.ToString() + ".json";
            while (File.Exists(CurrentFile))
            {
                QuestionsList.Add(new Question(CurrentFile, tableLayoutPanel3));
                i++;
                CurrentFile = "Questions/Customer/Question" + i.ToString() + ".json";
            }

            ratio = 100F / i;
            for (int j = 0; j < i; j++)
                tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, ratio));
            

            MaxScore = CalculateMaxScore();

        }
    }
}

