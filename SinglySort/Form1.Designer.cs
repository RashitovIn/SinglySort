namespace SinglySort
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenLB = new System.Windows.Forms.ListBox();
            this.sizeInp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.intInp = new System.Windows.Forms.Button();
            this.strInp = new System.Windows.Forms.Button();
            this.doubleInp = new System.Windows.Forms.Button();
            this.manSortDouble = new System.Windows.Forms.Button();
            this.clearInp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.manInp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BSortLB = new System.Windows.Forms.ListBox();
            this.QSortLB = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timeLabB = new System.Windows.Forms.Label();
            this.cComB = new System.Windows.Forms.Label();
            this.cTrB = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cComQ = new System.Windows.Forms.Label();
            this.cTrQ = new System.Windows.Forms.Label();
            this.timeLabQ = new System.Windows.Forms.Label();
            this.manSortString = new System.Windows.Forms.Button();
            this.manSortInt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рандомная генерация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(332, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ручной ввод";
            // 
            // GenLB
            // 
            this.GenLB.FormattingEnabled = true;
            this.GenLB.Location = new System.Drawing.Point(15, 265);
            this.GenLB.Name = "GenLB";
            this.GenLB.Size = new System.Drawing.Size(195, 212);
            this.GenLB.TabIndex = 2;
            // 
            // sizeInp
            // 
            this.sizeInp.Location = new System.Drawing.Point(15, 53);
            this.sizeInp.Name = "sizeInp";
            this.sizeInp.Size = new System.Drawing.Size(195, 20);
            this.sizeInp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Размер списка:";
            // 
            // intInp
            // 
            this.intInp.Location = new System.Drawing.Point(15, 79);
            this.intInp.Name = "intInp";
            this.intInp.Size = new System.Drawing.Size(195, 23);
            this.intInp.TabIndex = 5;
            this.intInp.Text = "(int) Сортировать целые числа";
            this.intInp.UseVisualStyleBackColor = true;
            this.intInp.Click += new System.EventHandler(this.IntInp_Click);
            // 
            // strInp
            // 
            this.strInp.Location = new System.Drawing.Point(15, 137);
            this.strInp.Name = "strInp";
            this.strInp.Size = new System.Drawing.Size(195, 23);
            this.strInp.TabIndex = 6;
            this.strInp.Text = "(string) Сортировать строки";
            this.strInp.UseVisualStyleBackColor = true;
            this.strInp.Click += new System.EventHandler(this.StrInp_Click);
            // 
            // doubleInp
            // 
            this.doubleInp.Location = new System.Drawing.Point(15, 108);
            this.doubleInp.Name = "doubleInp";
            this.doubleInp.Size = new System.Drawing.Size(195, 23);
            this.doubleInp.TabIndex = 7;
            this.doubleInp.Text = "(double) Сортировать вещ. числа";
            this.doubleInp.UseVisualStyleBackColor = true;
            this.doubleInp.Click += new System.EventHandler(this.DoubleInp_Click);
            // 
            // manSortDouble
            // 
            this.manSortDouble.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.manSortDouble.Location = new System.Drawing.Point(557, 137);
            this.manSortDouble.Name = "manSortDouble";
            this.manSortDouble.Size = new System.Drawing.Size(195, 39);
            this.manSortDouble.TabIndex = 8;
            this.manSortDouble.Text = "Сортировка ручного ввода (double)";
            this.manSortDouble.UseVisualStyleBackColor = false;
            this.manSortDouble.Click += new System.EventHandler(this.ManSortDouble_Click);
            // 
            // clearInp
            // 
            this.clearInp.Location = new System.Drawing.Point(557, 37);
            this.clearInp.Name = "clearInp";
            this.clearInp.Size = new System.Drawing.Size(195, 49);
            this.clearInp.TabIndex = 9;
            this.clearInp.Text = "Очистить всё";
            this.clearInp.UseVisualStyleBackColor = true;
            this.clearInp.Click += new System.EventHandler(this.ClearInp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Сгенерированный список";
            // 
            // manInp
            // 
            this.manInp.Location = new System.Drawing.Point(289, 34);
            this.manInp.Multiline = true;
            this.manInp.Name = "manInp";
            this.manInp.Size = new System.Drawing.Size(195, 187);
            this.manInp.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(286, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Пузырьковая сортировка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(534, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Быстрая сортировка рекурсиями";
            // 
            // BSortLB
            // 
            this.BSortLB.FormattingEnabled = true;
            this.BSortLB.Location = new System.Drawing.Point(287, 265);
            this.BSortLB.Name = "BSortLB";
            this.BSortLB.Size = new System.Drawing.Size(195, 212);
            this.BSortLB.TabIndex = 15;
            // 
            // QSortLB
            // 
            this.QSortLB.FormattingEnabled = true;
            this.QSortLB.Location = new System.Drawing.Point(557, 265);
            this.QSortLB.Name = "QSortLB";
            this.QSortLB.Size = new System.Drawing.Size(195, 212);
            this.QSortLB.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 490);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Потраченное время:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Количество перестановок:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 537);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Количество сравнений:";
            // 
            // timeLabB
            // 
            this.timeLabB.AutoSize = true;
            this.timeLabB.Location = new System.Drawing.Point(474, 490);
            this.timeLabB.Name = "timeLabB";
            this.timeLabB.Size = new System.Drawing.Size(10, 13);
            this.timeLabB.TabIndex = 20;
            this.timeLabB.Text = "-";
            // 
            // cComB
            // 
            this.cComB.AutoSize = true;
            this.cComB.Location = new System.Drawing.Point(474, 537);
            this.cComB.Name = "cComB";
            this.cComB.Size = new System.Drawing.Size(10, 13);
            this.cComB.TabIndex = 22;
            this.cComB.Text = "-";
            // 
            // cTrB
            // 
            this.cTrB.AutoSize = true;
            this.cTrB.Location = new System.Drawing.Point(474, 513);
            this.cTrB.Name = "cTrB";
            this.cTrB.Size = new System.Drawing.Size(10, 13);
            this.cTrB.TabIndex = 23;
            this.cTrB.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(554, 490);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Потраченное время:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(554, 513);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Количество перестановок:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(554, 537);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Количество сравнений:";
            // 
            // cComQ
            // 
            this.cComQ.AutoSize = true;
            this.cComQ.Location = new System.Drawing.Point(742, 537);
            this.cComQ.Name = "cComQ";
            this.cComQ.Size = new System.Drawing.Size(10, 13);
            this.cComQ.TabIndex = 27;
            this.cComQ.Text = "-";
            // 
            // cTrQ
            // 
            this.cTrQ.AutoSize = true;
            this.cTrQ.Location = new System.Drawing.Point(742, 513);
            this.cTrQ.Name = "cTrQ";
            this.cTrQ.Size = new System.Drawing.Size(10, 13);
            this.cTrQ.TabIndex = 28;
            this.cTrQ.Text = "-";
            // 
            // timeLabQ
            // 
            this.timeLabQ.AutoSize = true;
            this.timeLabQ.Location = new System.Drawing.Point(742, 490);
            this.timeLabQ.Name = "timeLabQ";
            this.timeLabQ.Size = new System.Drawing.Size(10, 13);
            this.timeLabQ.TabIndex = 29;
            this.timeLabQ.Text = "-";
            // 
            // manSortString
            // 
            this.manSortString.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.manSortString.Location = new System.Drawing.Point(557, 182);
            this.manSortString.Name = "manSortString";
            this.manSortString.Size = new System.Drawing.Size(195, 39);
            this.manSortString.TabIndex = 30;
            this.manSortString.Text = "Сортировка ручного ввода (string)";
            this.manSortString.UseVisualStyleBackColor = false;
            this.manSortString.Click += new System.EventHandler(this.ManSortString_Click);
            // 
            // manSortInt
            // 
            this.manSortInt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.manSortInt.Location = new System.Drawing.Point(557, 92);
            this.manSortInt.Name = "manSortInt";
            this.manSortInt.Size = new System.Drawing.Size(195, 39);
            this.manSortInt.TabIndex = 31;
            this.manSortInt.Text = "Сортировка ручного ввода (int)";
            this.manSortInt.UseVisualStyleBackColor = false;
            this.manSortInt.Click += new System.EventHandler(this.ManSortInt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.manSortInt);
            this.Controls.Add(this.manSortString);
            this.Controls.Add(this.timeLabQ);
            this.Controls.Add(this.cTrQ);
            this.Controls.Add(this.cComQ);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cTrB);
            this.Controls.Add(this.cComB);
            this.Controls.Add(this.timeLabB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.QSortLB);
            this.Controls.Add(this.BSortLB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.manInp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clearInp);
            this.Controls.Add(this.manSortDouble);
            this.Controls.Add(this.doubleInp);
            this.Controls.Add(this.strInp);
            this.Controls.Add(this.intInp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sizeInp);
            this.Controls.Add(this.GenLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox GenLB;
        private System.Windows.Forms.TextBox sizeInp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button intInp;
        private System.Windows.Forms.Button strInp;
        private System.Windows.Forms.Button doubleInp;
        private System.Windows.Forms.Button manSortDouble;
        private System.Windows.Forms.Button clearInp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox manInp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox BSortLB;
        private System.Windows.Forms.ListBox QSortLB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label timeLabB;
        private System.Windows.Forms.Label cComB;
        private System.Windows.Forms.Label cTrB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label cComQ;
        private System.Windows.Forms.Label cTrQ;
        private System.Windows.Forms.Label timeLabQ;
        private System.Windows.Forms.Button manSortString;
        private System.Windows.Forms.Button manSortInt;
    }
}

