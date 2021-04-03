
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
            this.tb_Qualiy = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Customer = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Done = new System.Windows.Forms.Button();
            this.tc_Main.SuspendLayout();
            this.tb_Interface.SuspendLayout();
            this.tb_Qualiy.SuspendLayout();
            this.tb_Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_Main
            // 
            this.tc_Main.Controls.Add(this.tb_Interface);
            this.tc_Main.Controls.Add(this.tb_Qualiy);
            this.tc_Main.Controls.Add(this.tb_Customer);
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
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 472);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_Qualiy
            // 
            this.tb_Qualiy.Controls.Add(this.tableLayoutPanel2);
            this.tb_Qualiy.Location = new System.Drawing.Point(4, 22);
            this.tb_Qualiy.Name = "tb_Qualiy";
            this.tb_Qualiy.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Qualiy.Size = new System.Drawing.Size(735, 496);
            this.tb_Qualiy.TabIndex = 1;
            this.tb_Qualiy.Text = "Функциональность";
            this.tb_Qualiy.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(718, 480);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tb_Customer
            // 
            this.tb_Customer.Controls.Add(this.tableLayoutPanel3);
            this.tb_Customer.Location = new System.Drawing.Point(4, 22);
            this.tb_Customer.Name = "tb_Customer";
            this.tb_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Customer.Size = new System.Drawing.Size(735, 496);
            this.tb_Customer.TabIndex = 2;
            this.tb_Customer.Text = "Требования заказчика";
            this.tb_Customer.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(718, 480);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // bt_Done
            // 
            this.bt_Done.Location = new System.Drawing.Point(563, 550);
            this.bt_Done.Name = "bt_Done";
            this.bt_Done.Size = new System.Drawing.Size(164, 59);
            this.bt_Done.TabIndex = 1;
            this.bt_Done.Text = "Готово";
            this.bt_Done.UseVisualStyleBackColor = true;
            this.bt_Done.Click += new System.EventHandler(this.Bt_Done_Click);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tc_Main.ResumeLayout(false);
            this.tb_Interface.ResumeLayout(false);
            this.tb_Qualiy.ResumeLayout(false);
            this.tb_Customer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tc_Main;
        public System.Windows.Forms.TabPage tb_Interface;
        public System.Windows.Forms.TabPage tb_Qualiy;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button bt_Done;
        public System.Windows.Forms.TabPage tb_Customer;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

