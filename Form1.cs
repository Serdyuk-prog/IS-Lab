using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace IS_Lab1
{
    public partial class Form1 : Form
    {
        //Список вопросов
        private readonly List<Question> QuestionsList = new List<Question>();
        //
        //Список проблем
        private readonly List<string> ProblemsList = new List<string>();
        //
        //Максимально возможное количество баллов
        private double MaxScore;
        private double MaxCustomerScore;
        //
        //Количество вопросов по категориям
        private int UIQstCount;
        private int QltQstCount;
        private int CustomerQstCount;
        //
        //Переменные для подсчета баллов по категориям
        private double UIScore;
        private double QltScore;
        private double CustomerScore;
        private double TotalScore;

        //конструктор класса Form1
        public Form1()
        {
            InitializeComponent();
        }
        //
        //Функция подсчета результатов
        public void CalculateResult()
        {
            //Обнуление переменных
            UIScore = 0;
            QltScore = 0;
            CustomerScore = 0;
            //
            int i;
            //подсчет баллов в категории "Интерфейс"
            for (i = 0; i < UIQstCount; i++)
                UIScore += QuestionsList[i].Answers[QuestionsList[i].cb.Text];
            //подсчет баллов в категории "Функционал"
            for (; i < UIQstCount + QltQstCount; i++)
                QltScore += QuestionsList[i].Answers[QuestionsList[i].cb.Text];
            //подсчет баллов в категории "Требования заказчика"
            for (; i < QuestionsList.Count; i++)
                CustomerScore += QuestionsList[i].Answers[QuestionsList[i].cb.Text];
            //
            //Подсчет общего количества баллов
            TotalScore = UIScore + QltScore + CustomerScore;
        }
        //Функция подсчета максимально возможного количества баллов
        private double CalculateMaxScore()
        {
            double score = 0;
            //подсчет максимально возможного количества баллов
            for (int i = 0; i < QuestionsList.Count; i++)
                score += QuestionsList[i].MaxScore;
            //подсчет максимально возможного количества баллов в категории "Требования заказчика"
            MaxCustomerScore = 0;
            for (int i = UIQstCount + QltQstCount; i < QuestionsList.Count; i++)
                MaxCustomerScore += QuestionsList[i].MaxScore;
            
            return score;
        }
        //Функция, составляющая список проблем
        private void SetProblemsList()
        {
            for (int i = 0; i < QuestionsList.Count; i++)
            {
                double currentScore = (QuestionsList[i].Answers[QuestionsList[i].cb.Text]);
                if ((currentScore < QuestionsList[i].MaxScore - 1) || (currentScore == 0))
                   if(!(QuestionsList[i].ErrorMessage == ""))
                        ProblemsList.Add(QuestionsList[i].ErrorMessage);
            }
        }

        //Метод нажатия кнопки
        private void Bt_Done_Click(object sender, EventArgs e)
        {
            //Проверка полноты введенных данных
            if (CbIsEmpty())
            {
                MessageBox.Show("Вы ввели не все данные!", "Ошибка");
                return;
            }
            //
            //Очистка списка проблем
            ProblemsList.Clear();
            //Вызов функции, составляющей список проблем
            SetProblemsList();
            //
            //Вызов функции подсчета результатов
            CalculateResult();
            //
            //Переменная, содержащая текст сообщения с результатом
            string MessageText = "";
            //Проверка выполнения четких требований заказчика
            if (!(MaxCustomerScore == CustomerScore))
            {
                MessageText += "Программа не соответствует требованиям заказчика! \n";                                                                                                               
                MessageText += "Программа нуждается в полной переработке!\n Необходимо:\n" + String.Join(",\n", ProblemsList.ToArray());
            }
            //Проверка соответствия нормам качества 
            else if (TotalScore >= MaxScore * 0.75)
                MessageText += "Требования заказчика удовлетворены, программа готова к релизу";
            else if (TotalScore >= MaxScore * 0.50)
                MessageText += "Программе требуется частичная доработка.\nН еобходимо:\n" + String.Join(",\n", ProblemsList.ToArray());
            else
                MessageText += "Программа нуждается в полной переработке!\n Необходимо:\n" + String.Join(",\n", ProblemsList.ToArray());
            //
            //Вызов окна с резальтатами 
            MessageBox.Show(MessageText, "Результат");
        }

        //Метод проверки пустоты элементов ComboBox
        public bool CbIsEmpty()
        {
            for (int i = 0; i < QuestionsList.Count; i++)            
                if (QuestionsList[i].cb.SelectedIndex == -1)
                    return true;            
            return false;
        }

        //Метод выполняемый при загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {            
            int i = 1;
            //загрузка вопросов категории "Интерфейс"
            string CurrentFile = "Questions/UI/Question" + i.ToString() + ".json";
            while (File.Exists(CurrentFile))
            {
                //добавление вопросов в список 
                QuestionsList.Add(new Question(CurrentFile, tableLayoutPanel1));
                i++;
                CurrentFile = "Questions/UI/Question" + i.ToString() + ".json";
            }
            UIQstCount = i - 1;
            //
            //установка параметров форматирования для tableLayoutPanel
            float ratio = 100F/ i;
            for (int j = 0; j < i; j++)
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, ratio));
            //
            //загрузка вопросов категории "Функциональность"
            i = 1;
            CurrentFile = "Questions/Quality/Question" + i.ToString() + ".json";
            while (File.Exists(CurrentFile))
            {
                QuestionsList.Add(new Question(CurrentFile, tableLayoutPanel2));
                i++;
                CurrentFile = "Questions/Quality/Question" + i.ToString() + ".json";
            }
            QltQstCount = i - 1;
            //
            //установка параметров форматирования для tableLayoutPanel
            ratio = 100F / i;
            for (int j = 0; j < i; j++)
                tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, ratio));
            //
            //загрузка вопросов категории "Требований заказчика"
            i = 1;
            CurrentFile = "Questions/Customer/Question" + i.ToString() + ".json";
            while (File.Exists(CurrentFile))
            {
                QuestionsList.Add(new Question(CurrentFile, tableLayoutPanel3));
                i++;
                CurrentFile = "Questions/Customer/Question" + i.ToString() + ".json";
            }
            CustomerQstCount = i - 1;
            ratio = 100F / i;
            for (int j = 0; j < i; j++)
                tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, ratio));
            
            
            MaxScore = CalculateMaxScore();

        }
    }
}

