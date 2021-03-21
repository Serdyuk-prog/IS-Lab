
namespace IS_Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tc_Main = new System.Windows.Forms.TabControl();
            this.tb_Interface = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gb_Q2 = new System.Windows.Forms.GroupBox();
            this.cb_Q2 = new System.Windows.Forms.ComboBox();
            this.lb_Int_Q1 = new System.Windows.Forms.Label();
            this.gb_Q1 = new System.Windows.Forms.GroupBox();
            this.cb_Q1 = new System.Windows.Forms.ComboBox();
            this.lb_Int_Q2 = new System.Windows.Forms.Label();
            this.tb_Qualiy = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gb_Qlt_Q4 = new System.Windows.Forms.GroupBox();
            this.cb_Qlt_Q4 = new System.Windows.Forms.ComboBox();
            this.gb_Qlt_Q3 = new System.Windows.Forms.GroupBox();
            this.cb_Qlt_Q3 = new System.Windows.Forms.ComboBox();
            this.gb_Qlt_Q2 = new System.Windows.Forms.GroupBox();
            this.cb_Qlt_Q2 = new System.Windows.Forms.ComboBox();
            this.lb_Qlt_Q1 = new System.Windows.Forms.Label();
            this.lb_Qlt_Q2 = new System.Windows.Forms.Label();
            this.lb_Qlt_Q3 = new System.Windows.Forms.Label();
            this.lb_Qlt_Q4 = new System.Windows.Forms.Label();
            this.gb_Qlt_Q1 = new System.Windows.Forms.GroupBox();
            this.cb_Qlt_Q1 = new System.Windows.Forms.ComboBox();
            this.bt_Done = new System.Windows.Forms.Button();
            this.tc_Main.SuspendLayout();
            this.tb_Interface.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_Q2.SuspendLayout();
            this.gb_Q1.SuspendLayout();
            this.tb_Qualiy.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gb_Qlt_Q4.SuspendLayout();
            this.gb_Qlt_Q3.SuspendLayout();
            this.gb_Qlt_Q2.SuspendLayout();
            this.gb_Qlt_Q1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_Main
            // 
            this.tc_Main.Controls.Add(this.tb_Interface);
            this.tc_Main.Controls.Add(this.tb_Qualiy);
            this.tc_Main.Location = new System.Drawing.Point(12, 12);
            this.tc_Main.Name = "tc_Main";
            this.tc_Main.SelectedIndex = 0;
            this.tc_Main.Size = new System.Drawing.Size(743, 522);
            this.tc_Main.TabIndex = 0;
            // 
            // tb_Interface
            // 
            this.tb_Interface.AutoScroll = true;
            this.tb_Interface.Controls.Add(this.tableLayoutPanel1);
            this.tb_Interface.Location = new System.Drawing.Point(4, 22);
            this.tb_Interface.Name = "tb_Interface";
            this.tb_Interface.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Interface.Size = new System.Drawing.Size(735, 496);
            this.tb_Interface.TabIndex = 0;
            this.tb_Interface.Text = "Интерфейс";
            this.tb_Interface.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.03448F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.96552F));
            this.tableLayoutPanel1.Controls.Add(this.gb_Q2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_Int_Q1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gb_Q1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Int_Q2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 472);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // gb_Q2
            // 
            this.gb_Q2.Controls.Add(this.cb_Q2);
            this.gb_Q2.Location = new System.Drawing.Point(541, 240);
            this.gb_Q2.Name = "gb_Q2";
            this.gb_Q2.Size = new System.Drawing.Size(172, 180);
            this.gb_Q2.TabIndex = 3;
            this.gb_Q2.TabStop = false;
            // 
            // cb_Q2
            // 
            this.cb_Q2.FormattingEnabled = true;
            this.cb_Q2.Items.AddRange(new object[] {
            "Отлично",
            "Хорошо",
            "Удовлетворительно",
            "Плохо"});
            this.cb_Q2.Location = new System.Drawing.Point(6, 42);
            this.cb_Q2.Name = "cb_Q2";
            this.cb_Q2.Size = new System.Drawing.Size(160, 21);
            this.cb_Q2.TabIndex = 0;
            this.cb_Q2.SelectedIndexChanged += new System.EventHandler(this.cb_Q2_SelectedIndexChanged);
            // 
            // lb_Int_Q1
            // 
            this.lb_Int_Q1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Int_Q1.AutoSize = true;
            this.lb_Int_Q1.Location = new System.Drawing.Point(6, 3);
            this.lb_Int_Q1.Name = "lb_Int_Q1";
            this.lb_Int_Q1.Size = new System.Drawing.Size(526, 231);
            this.lb_Int_Q1.TabIndex = 0;
            this.lb_Int_Q1.Text = "Средняя скорость загрузки страниц";
            // 
            // gb_Q1
            // 
            this.gb_Q1.Controls.Add(this.cb_Q1);
            this.gb_Q1.Location = new System.Drawing.Point(541, 6);
            this.gb_Q1.Name = "gb_Q1";
            this.gb_Q1.Size = new System.Drawing.Size(172, 179);
            this.gb_Q1.TabIndex = 1;
            this.gb_Q1.TabStop = false;
            // 
            // cb_Q1
            // 
            this.cb_Q1.FormattingEnabled = true;
            this.cb_Q1.Items.AddRange(new object[] {
            "Отлично",
            "Хорошо",
            "Удовлетворительно",
            "Плохо"});
            this.cb_Q1.Location = new System.Drawing.Point(6, 42);
            this.cb_Q1.Name = "cb_Q1";
            this.cb_Q1.Size = new System.Drawing.Size(160, 21);
            this.cb_Q1.TabIndex = 0;
            this.cb_Q1.SelectedIndexChanged += new System.EventHandler(this.cb_Q1_SelectedIndexChanged);
            // 
            // lb_Int_Q2
            // 
            this.lb_Int_Q2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Int_Q2.AutoSize = true;
            this.lb_Int_Q2.Location = new System.Drawing.Point(6, 237);
            this.lb_Int_Q2.Name = "lb_Int_Q2";
            this.lb_Int_Q2.Size = new System.Drawing.Size(526, 232);
            this.lb_Int_Q2.TabIndex = 2;
            this.lb_Int_Q2.Text = "Среднее количество ошибок пользователей при работе с функциями ПО\r\n";
            // 
            // tb_Qualiy
            // 
            this.tb_Qualiy.Controls.Add(this.tableLayoutPanel2);
            this.tb_Qualiy.Location = new System.Drawing.Point(4, 22);
            this.tb_Qualiy.Name = "tb_Qualiy";
            this.tb_Qualiy.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Qualiy.Size = new System.Drawing.Size(735, 496);
            this.tb_Qualiy.TabIndex = 1;
            this.tb_Qualiy.Text = "Качество продукта";
            this.tb_Qualiy.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
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
            // 
            // gb_Qlt_Q4
            // 
            this.gb_Qlt_Q4.Controls.Add(this.cb_Qlt_Q4);
            this.gb_Qlt_Q4.Location = new System.Drawing.Point(540, 363);
            this.gb_Qlt_Q4.Name = "gb_Qlt_Q4";
            this.gb_Qlt_Q4.Size = new System.Drawing.Size(172, 92);
            this.gb_Qlt_Q4.TabIndex = 7;
            this.gb_Qlt_Q4.TabStop = false;
            // 
            // cb_Qlt_Q4
            // 
            this.cb_Qlt_Q4.FormattingEnabled = true;
            this.cb_Qlt_Q4.Items.AddRange(new object[] {
            "Сильная",
            "Средняя",
            "Слабая"});
            this.cb_Qlt_Q4.Location = new System.Drawing.Point(6, 39);
            this.cb_Qlt_Q4.Name = "cb_Qlt_Q4";
            this.cb_Qlt_Q4.Size = new System.Drawing.Size(162, 21);
            this.cb_Qlt_Q4.TabIndex = 0;
            this.cb_Qlt_Q4.SelectedIndexChanged += new System.EventHandler(this.cb_Qlt_Q4_SelectedIndexChanged);
            // 
            // gb_Qlt_Q3
            // 
            this.gb_Qlt_Q3.Controls.Add(this.cb_Qlt_Q3);
            this.gb_Qlt_Q3.Location = new System.Drawing.Point(540, 244);
            this.gb_Qlt_Q3.Name = "gb_Qlt_Q3";
            this.gb_Qlt_Q3.Size = new System.Drawing.Size(172, 89);
            this.gb_Qlt_Q3.TabIndex = 6;
            this.gb_Qlt_Q3.TabStop = false;
            // 
            // cb_Qlt_Q3
            // 
            this.cb_Qlt_Q3.FormattingEnabled = true;
            this.cb_Qlt_Q3.Items.AddRange(new object[] {
            "Критичное",
            "Много",
            "Незначительно",
            "Отсутствуют"});
            this.cb_Qlt_Q3.Location = new System.Drawing.Point(6, 36);
            this.cb_Qlt_Q3.Name = "cb_Qlt_Q3";
            this.cb_Qlt_Q3.Size = new System.Drawing.Size(162, 21);
            this.cb_Qlt_Q3.TabIndex = 0;
            this.cb_Qlt_Q3.SelectedIndexChanged += new System.EventHandler(this.cb_Qlt_Q3_SelectedIndexChanged);
            // 
            // gb_Qlt_Q2
            // 
            this.gb_Qlt_Q2.Controls.Add(this.cb_Qlt_Q2);
            this.gb_Qlt_Q2.Location = new System.Drawing.Point(540, 125);
            this.gb_Qlt_Q2.Name = "gb_Qlt_Q2";
            this.gb_Qlt_Q2.Size = new System.Drawing.Size(172, 89);
            this.gb_Qlt_Q2.TabIndex = 5;
            this.gb_Qlt_Q2.TabStop = false;
            // 
            // cb_Qlt_Q2
            // 
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
            // 
            // lb_Qlt_Q1
            // 
            this.lb_Qlt_Q1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Qlt_Q1.AutoSize = true;
            this.lb_Qlt_Q1.Location = new System.Drawing.Point(6, 3);
            this.lb_Qlt_Q1.Name = "lb_Qlt_Q1";
            this.lb_Qlt_Q1.Size = new System.Drawing.Size(525, 116);
            this.lb_Qlt_Q1.TabIndex = 0;
            this.lb_Qlt_Q1.Text = "Средняя скорость выполнения функций ПО";
            // 
            // lb_Qlt_Q2
            // 
            this.lb_Qlt_Q2.AutoSize = true;
            this.lb_Qlt_Q2.Location = new System.Drawing.Point(6, 122);
            this.lb_Qlt_Q2.Name = "lb_Qlt_Q2";
            this.lb_Qlt_Q2.Size = new System.Drawing.Size(212, 13);
            this.lb_Qlt_Q2.TabIndex = 1;
            this.lb_Qlt_Q2.Text = "Степень совместимости с версиями ОС";
            // 
            // lb_Qlt_Q3
            // 
            this.lb_Qlt_Q3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Qlt_Q3.AutoSize = true;
            this.lb_Qlt_Q3.Location = new System.Drawing.Point(6, 241);
            this.lb_Qlt_Q3.Name = "lb_Qlt_Q3";
            this.lb_Qlt_Q3.Size = new System.Drawing.Size(525, 116);
            this.lb_Qlt_Q3.TabIndex = 2;
            this.lb_Qlt_Q3.Text = "Количество критически ошибкок";
            // 
            // lb_Qlt_Q4
            // 
            this.lb_Qlt_Q4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Qlt_Q4.AutoSize = true;
            this.lb_Qlt_Q4.Location = new System.Drawing.Point(6, 360);
            this.lb_Qlt_Q4.Name = "lb_Qlt_Q4";
            this.lb_Qlt_Q4.Size = new System.Drawing.Size(525, 117);
            this.lb_Qlt_Q4.TabIndex = 3;
            this.lb_Qlt_Q4.Text = "Степень устойчивости к кибератакам";
            // 
            // gb_Qlt_Q1
            // 
            this.gb_Qlt_Q1.Controls.Add(this.cb_Qlt_Q1);
            this.gb_Qlt_Q1.Location = new System.Drawing.Point(540, 6);
            this.gb_Qlt_Q1.Name = "gb_Qlt_Q1";
            this.gb_Qlt_Q1.Size = new System.Drawing.Size(172, 89);
            this.gb_Qlt_Q1.TabIndex = 4;
            this.gb_Qlt_Q1.TabStop = false;
            // 
            // cb_Qlt_Q1
            // 
            this.cb_Qlt_Q1.FormattingEnabled = true;
            this.cb_Qlt_Q1.Items.AddRange(new object[] {
            "Отлично",
            "Хорошо",
            "Удовлетворительно",
            "Плохо"});
            this.cb_Qlt_Q1.Location = new System.Drawing.Point(6, 37);
            this.cb_Qlt_Q1.Name = "cb_Qlt_Q1";
            this.cb_Qlt_Q1.Size = new System.Drawing.Size(162, 21);
            this.cb_Qlt_Q1.TabIndex = 0;
            this.cb_Qlt_Q1.SelectedIndexChanged += new System.EventHandler(this.cb_Qlt_Q1_SelectedIndexChanged);
            // 
            // bt_Done
            // 
            this.bt_Done.Location = new System.Drawing.Point(563, 550);
            this.bt_Done.Name = "bt_Done";
            this.bt_Done.Size = new System.Drawing.Size(164, 59);
            this.bt_Done.TabIndex = 1;
            this.bt_Done.Text = "Готово";
            this.bt_Done.UseVisualStyleBackColor = true;
            this.bt_Done.Click += new System.EventHandler(this.bt_Done_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 621);
            this.Controls.Add(this.bt_Done);
            this.Controls.Add(this.tc_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Экспертная система оценки качества программного обеспечения";
            this.tc_Main.ResumeLayout(false);
            this.tb_Interface.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gb_Q2.ResumeLayout(false);
            this.gb_Q1.ResumeLayout(false);
            this.tb_Qualiy.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gb_Qlt_Q4.ResumeLayout(false);
            this.gb_Qlt_Q3.ResumeLayout(false);
            this.gb_Qlt_Q2.ResumeLayout(false);
            this.gb_Qlt_Q1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Main;
        private System.Windows.Forms.TabPage tb_Interface;
        private System.Windows.Forms.TabPage tb_Qualiy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_Int_Q1;
        private System.Windows.Forms.GroupBox gb_Q1;
        private System.Windows.Forms.ComboBox cb_Q1;
        private System.Windows.Forms.Label lb_Int_Q2;
        private System.Windows.Forms.GroupBox gb_Q2;
        private System.Windows.Forms.ComboBox cb_Q2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gb_Qlt_Q4;
        private System.Windows.Forms.ComboBox cb_Qlt_Q4;
        private System.Windows.Forms.GroupBox gb_Qlt_Q3;
        private System.Windows.Forms.ComboBox cb_Qlt_Q3;
        private System.Windows.Forms.GroupBox gb_Qlt_Q2;
        private System.Windows.Forms.ComboBox cb_Qlt_Q2;
        private System.Windows.Forms.Label lb_Qlt_Q1;
        private System.Windows.Forms.Label lb_Qlt_Q2;
        private System.Windows.Forms.Label lb_Qlt_Q3;
        private System.Windows.Forms.Label lb_Qlt_Q4;
        private System.Windows.Forms.GroupBox gb_Qlt_Q1;
        private System.Windows.Forms.ComboBox cb_Qlt_Q1;
        private System.Windows.Forms.Button bt_Done;
    }
}

