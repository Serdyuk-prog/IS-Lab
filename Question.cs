using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace IS_Lab1
{
    class Question
    {
        public ComboBox cb = new ComboBox();
        public Label lb = new Label();
        public string QuestionText;
        public double MaxScore;
        public int AnswersCount;
        public string ErrorMessage;
        public Dictionary<string, double> Answers = new Dictionary<string, double>();

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
            //            form.tableLayoutPanel1.RowCount++;
            //            form.tableLayoutPanel1.Controls.Add(new Label { Text = "Type:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, 0);
            //            form.tableLayoutPanel1.Controls.Add(new ComboBox { Dock = DockStyle.Fill }, 0, 0);
            tableLayoutPanel.Controls.Add(cb, 0, 0);
            cb.Dock = DockStyle.Fill;     
            
            tableLayoutPanel.Controls.Add(lb, 0, 0);
            lb.Text = QuestionText;
            lb.AutoSize = true;
            lb.Anchor = (((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));



        }




    }
}

/*
             this.cb_Qlt_Q2.FormattingEnabled = true;
            this.cb_Qlt_Q2.Items.AddRange(new object[] {
            "Совместима со многими старыми версиями ОС",
            "Совместима со свежими версиями ОС",
            "Совместима только с текущей версией ОС"});
            this.cb_Qlt_Q2.Location = new System.Drawing.Point(6, 37);
            this.cb_Qlt_Q2.Name = "cb_Qlt_Q2";
            this.cb_Qlt_Q2.Size = new System.Drawing.Size(162, 21);
            this.cb_Qlt_Q2.TabIndex = 0;
            this.cb_Qlt_Q2.SelectedIndexChanged += new System.EventHandler(this.cb_Qlt_Q2_SelectedIndexChanged);
 




            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.gb_Qlt_Q4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.gb_Qlt_Q3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.gb_Qlt_Q2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_Qlt_Q1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_Qlt_Q2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_Qlt_Q3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_Qlt_Q4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.gb_Qlt_Q1, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(718, 480);
            this.tableLayoutPanel2.TabIndex = 0;
 * 
 * 
 * 
 * 
 * 
Table.Controls.Add(new Label { Text = "Type:", Anchor = AnchorStyles.Left, AutoSize = true }, 0, 0);
Table.Controls.Add(new ComboBox { Dock = DockStyle.Fill }, 0, 1);
 */