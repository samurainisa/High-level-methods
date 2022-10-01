namespace OverloadingOperators
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
            this.tbstringchar = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.operplus = new System.Windows.Forms.Label();
            this.tbplus = new System.Windows.Forms.TextBox();
            this.startbtn = new System.Windows.Forms.Button();
            this.tbequals = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnonequals = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbaddedstring = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closetbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.helpbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genbtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbstringchar
            // 
            this.tbstringchar.Location = new System.Drawing.Point(117, 47);
            this.tbstringchar.Name = "tbstringchar";
            this.tbstringchar.Size = new System.Drawing.Size(169, 20);
            this.tbstringchar.TabIndex = 0;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(162, 70);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(70, 13);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Ввод строки";
            // 
            // operplus
            // 
            this.operplus.AutoSize = true;
            this.operplus.Location = new System.Drawing.Point(164, 168);
            this.operplus.Name = "operplus";
            this.operplus.Size = new System.Drawing.Size(55, 13);
            this.operplus.TabIndex = 2;
            this.operplus.Text = "operator +";
            // 
            // tbplus
            // 
            this.tbplus.Location = new System.Drawing.Point(117, 145);
            this.tbplus.Name = "tbplus";
            this.tbplus.Size = new System.Drawing.Size(169, 20);
            this.tbplus.TabIndex = 3;
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(142, 330);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(117, 43);
            this.startbtn.TabIndex = 4;
            this.startbtn.Text = "START";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // tbequals
            // 
            this.tbequals.Location = new System.Drawing.Point(117, 206);
            this.tbequals.Name = "tbequals";
            this.tbequals.Size = new System.Drawing.Size(169, 20);
            this.tbequals.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "operator ==";
            // 
            // tbnonequals
            // 
            this.tbnonequals.Location = new System.Drawing.Point(117, 257);
            this.tbnonequals.Name = "tbnonequals";
            this.tbnonequals.Size = new System.Drawing.Size(169, 20);
            this.tbnonequals.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "operator !=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Добавляемая строка";
            // 
            // tbaddedstring
            // 
            this.tbaddedstring.Location = new System.Drawing.Point(316, 47);
            this.tbaddedstring.Name = "tbaddedstring";
            this.tbaddedstring.Size = new System.Drawing.Size(169, 20);
            this.tbaddedstring.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(321, 134);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(164, 159);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Строка в виде массива";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(404, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closetbtn,
            this.helpbtn,
            this.очиститьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closetbtn
            // 
            this.closetbtn.Name = "closetbtn";
            this.closetbtn.Size = new System.Drawing.Size(54, 20);
            this.closetbtn.Text = "Выход";
            this.closetbtn.Click += new System.EventHandler(this.closetbtn_Click);
            // 
            // helpbtn
            // 
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.Size = new System.Drawing.Size(68, 20);
            this.helpbtn.Text = "Помощь";
            this.helpbtn.Click += new System.EventHandler(this.helpbtn_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // genbtn
            // 
            this.genbtn.Location = new System.Drawing.Point(281, 333);
            this.genbtn.Name = "genbtn";
            this.genbtn.Size = new System.Drawing.Size(89, 36);
            this.genbtn.TabIndex = 17;
            this.genbtn.Text = "Gen";
            this.genbtn.UseVisualStyleBackColor = true;
            this.genbtn.Click += new System.EventHandler(this.genbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 422);
            this.Controls.Add(this.genbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbaddedstring);
            this.Controls.Add(this.tbnonequals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbequals);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.tbplus);
            this.Controls.Add(this.operplus);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.tbstringchar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbstringchar;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label operplus;
        private System.Windows.Forms.TextBox tbplus;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.TextBox tbequals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnonequals;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbaddedstring;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closetbtn;
        private System.Windows.Forms.ToolStripMenuItem helpbtn;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.Button genbtn;
    }
}

