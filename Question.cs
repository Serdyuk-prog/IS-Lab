using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace IS_Lab1
{
    class Question
    {
        //Элементы интерфейса
        public ComboBox cb = new ComboBox();
        public Label lb = new Label();
        //Текст вопроса
        public string QuestionText;
        //Максимально возможное количество баллов
        public double MaxScore;
        //Количество ответов на вопрос
        public int AnswersCount;
        //Текст проблеммы
        public string ErrorMessage;
        public Dictionary<string, double> Answers = new Dictionary<string, double>();
        
        //Конструктор класса Question
        public Question(string filepath, TableLayoutPanel tableLayoutPanel)
        {
            JsonRead(filepath);
            Init(tableLayoutPanel);
        }
        
        //чтение данных вопроса из файла
        private void JsonRead(string filepath)
        {
            StreamReader r = new StreamReader(filepath);
            string json = r.ReadToEnd();
            FromJson fromjson = JsonConvert.DeserializeObject<FromJson>(json);

            MaxScore = fromjson.MaxScore;
            QuestionText = fromjson.LabelText;
            AnswersCount = fromjson.Answers.Count;
            ErrorMessage = fromjson.ErrorMessage;
            for (int i = 0; i < AnswersCount; i++)
            {
                cb.Items.Add(fromjson.Answers[i]);
                Answers.Add(fromjson.Answers[i], AnswersCount - i - 1);
            }
            r.Close();
        }

        //размещение в tableLayoutPanel
        private void Init(TableLayoutPanel tableLayoutPanel)
        {

            tableLayoutPanel.Controls.Add(cb, 0, 0);
            cb.Dock = DockStyle.Fill;     
            
            tableLayoutPanel.Controls.Add(lb, 0, 0);
            lb.Text = QuestionText;
            lb.AutoSize = true;
            lb.Anchor = (((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));

        }

    }
}

