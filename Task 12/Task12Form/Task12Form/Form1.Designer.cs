namespace Task12Form
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
            this.sizeText = new System.Windows.Forms.TextBox();
            this.arrText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cocktailText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.heapText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.countCompCocText = new System.Windows.Forms.TextBox();
            this.countCompHeapText = new System.Windows.Forms.TextBox();
            this.countSwapCocText = new System.Windows.Forms.TextBox();
            this.countSwapHeapText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.countSwapHeapUpText = new System.Windows.Forms.TextBox();
            this.countSwapCocUpText = new System.Windows.Forms.TextBox();
            this.countCompHeapUpText = new System.Windows.Forms.TextBox();
            this.countCompCocUpText = new System.Windows.Forms.TextBox();
            this.heapUpText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cocktailUpText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.arrUpText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.countSwapHeapDownText = new System.Windows.Forms.TextBox();
            this.countSwapCocDownText = new System.Windows.Forms.TextBox();
            this.countCompHeapDownText = new System.Windows.Forms.TextBox();
            this.countCompCocDownText = new System.Windows.Forms.TextBox();
            this.heapDownText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cocktailDownText = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.arrDownText = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите размер массива";
            // 
            // sizeText
            // 
            this.sizeText.Location = new System.Drawing.Point(306, 70);
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(100, 20);
            this.sizeText.TabIndex = 1;
            this.sizeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // arrText
            // 
            this.arrText.Location = new System.Drawing.Point(306, 96);
            this.arrText.Name = "arrText";
            this.arrText.ReadOnly = true;
            this.arrText.Size = new System.Drawing.Size(100, 20);
            this.arrText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Массив заполненный случайно";
            // 
            // cocktailText
            // 
            this.cocktailText.Location = new System.Drawing.Point(306, 122);
            this.cocktailText.Name = "cocktailText";
            this.cocktailText.ReadOnly = true;
            this.cocktailText.Size = new System.Drawing.Size(100, 20);
            this.cocktailText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Результат работы сортировки перемешиванием";
            // 
            // heapText
            // 
            this.heapText.Location = new System.Drawing.Point(306, 148);
            this.heapText.Name = "heapText";
            this.heapText.ReadOnly = true;
            this.heapText.Size = new System.Drawing.Size(100, 20);
            this.heapText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Результат работы пирамидальной сортировки";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(543, 362);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 8;
            this.button.Text = "Готово";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // countCompCocText
            // 
            this.countCompCocText.Location = new System.Drawing.Point(412, 122);
            this.countCompCocText.Name = "countCompCocText";
            this.countCompCocText.ReadOnly = true;
            this.countCompCocText.Size = new System.Drawing.Size(100, 20);
            this.countCompCocText.TabIndex = 9;
            // 
            // countCompHeapText
            // 
            this.countCompHeapText.Location = new System.Drawing.Point(412, 148);
            this.countCompHeapText.Name = "countCompHeapText";
            this.countCompHeapText.ReadOnly = true;
            this.countCompHeapText.Size = new System.Drawing.Size(100, 20);
            this.countCompHeapText.TabIndex = 10;
            // 
            // countSwapCocText
            // 
            this.countSwapCocText.Location = new System.Drawing.Point(518, 122);
            this.countSwapCocText.Name = "countSwapCocText";
            this.countSwapCocText.ReadOnly = true;
            this.countSwapCocText.Size = new System.Drawing.Size(100, 20);
            this.countSwapCocText.TabIndex = 11;
            // 
            // countSwapHeapText
            // 
            this.countSwapHeapText.Location = new System.Drawing.Point(518, 148);
            this.countSwapHeapText.Name = "countSwapHeapText";
            this.countSwapHeapText.ReadOnly = true;
            this.countSwapHeapText.Size = new System.Drawing.Size(100, 20);
            this.countSwapHeapText.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Количество \r\nсравнений";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(528, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Количество\r\nперемещений";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 26);
            this.label7.TabIndex = 26;
            this.label7.Text = "Количество\r\nперемещений";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 26);
            this.label8.TabIndex = 25;
            this.label8.Text = "Количество \r\nсравнений";
            // 
            // countSwapHeapUpText
            // 
            this.countSwapHeapUpText.Location = new System.Drawing.Point(518, 231);
            this.countSwapHeapUpText.Name = "countSwapHeapUpText";
            this.countSwapHeapUpText.ReadOnly = true;
            this.countSwapHeapUpText.Size = new System.Drawing.Size(100, 20);
            this.countSwapHeapUpText.TabIndex = 24;
            // 
            // countSwapCocUpText
            // 
            this.countSwapCocUpText.Location = new System.Drawing.Point(518, 205);
            this.countSwapCocUpText.Name = "countSwapCocUpText";
            this.countSwapCocUpText.ReadOnly = true;
            this.countSwapCocUpText.Size = new System.Drawing.Size(100, 20);
            this.countSwapCocUpText.TabIndex = 23;
            // 
            // countCompHeapUpText
            // 
            this.countCompHeapUpText.Location = new System.Drawing.Point(412, 231);
            this.countCompHeapUpText.Name = "countCompHeapUpText";
            this.countCompHeapUpText.ReadOnly = true;
            this.countCompHeapUpText.Size = new System.Drawing.Size(100, 20);
            this.countCompHeapUpText.TabIndex = 22;
            // 
            // countCompCocUpText
            // 
            this.countCompCocUpText.Location = new System.Drawing.Point(412, 205);
            this.countCompCocUpText.Name = "countCompCocUpText";
            this.countCompCocUpText.ReadOnly = true;
            this.countCompCocUpText.Size = new System.Drawing.Size(100, 20);
            this.countCompCocUpText.TabIndex = 21;
            // 
            // heapUpText
            // 
            this.heapUpText.Location = new System.Drawing.Point(306, 231);
            this.heapUpText.Name = "heapUpText";
            this.heapUpText.ReadOnly = true;
            this.heapUpText.Size = new System.Drawing.Size(100, 20);
            this.heapUpText.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Результат работы пирамидальной сортировки";
            // 
            // cocktailUpText
            // 
            this.cocktailUpText.Location = new System.Drawing.Point(306, 205);
            this.cocktailUpText.Name = "cocktailUpText";
            this.cocktailUpText.ReadOnly = true;
            this.cocktailUpText.Size = new System.Drawing.Size(100, 20);
            this.cocktailUpText.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Результат работы сортировки перемешиванием";
            // 
            // arrUpText
            // 
            this.arrUpText.Location = new System.Drawing.Point(306, 179);
            this.arrUpText.Name = "arrUpText";
            this.arrUpText.ReadOnly = true;
            this.arrUpText.Size = new System.Drawing.Size(100, 20);
            this.arrUpText.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(240, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Массив - возрастающая последовательность";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(528, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 26);
            this.label12.TabIndex = 38;
            this.label12.Text = "Количество\r\nперемещений";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(431, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 26);
            this.label13.TabIndex = 37;
            this.label13.Text = "Количество \r\nсравнений";
            // 
            // countSwapHeapDownText
            // 
            this.countSwapHeapDownText.Location = new System.Drawing.Point(518, 316);
            this.countSwapHeapDownText.Name = "countSwapHeapDownText";
            this.countSwapHeapDownText.ReadOnly = true;
            this.countSwapHeapDownText.Size = new System.Drawing.Size(100, 20);
            this.countSwapHeapDownText.TabIndex = 36;
            // 
            // countSwapCocDownText
            // 
            this.countSwapCocDownText.Location = new System.Drawing.Point(518, 290);
            this.countSwapCocDownText.Name = "countSwapCocDownText";
            this.countSwapCocDownText.ReadOnly = true;
            this.countSwapCocDownText.Size = new System.Drawing.Size(100, 20);
            this.countSwapCocDownText.TabIndex = 35;
            // 
            // countCompHeapDownText
            // 
            this.countCompHeapDownText.Location = new System.Drawing.Point(412, 316);
            this.countCompHeapDownText.Name = "countCompHeapDownText";
            this.countCompHeapDownText.ReadOnly = true;
            this.countCompHeapDownText.Size = new System.Drawing.Size(100, 20);
            this.countCompHeapDownText.TabIndex = 34;
            // 
            // countCompCocDownText
            // 
            this.countCompCocDownText.Location = new System.Drawing.Point(412, 290);
            this.countCompCocDownText.Name = "countCompCocDownText";
            this.countCompCocDownText.ReadOnly = true;
            this.countCompCocDownText.Size = new System.Drawing.Size(100, 20);
            this.countCompCocDownText.TabIndex = 33;
            // 
            // heapDownText
            // 
            this.heapDownText.Location = new System.Drawing.Point(306, 316);
            this.heapDownText.Name = "heapDownText";
            this.heapDownText.ReadOnly = true;
            this.heapDownText.Size = new System.Drawing.Size(100, 20);
            this.heapDownText.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(244, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Результат работы пирамидальной сортировки";
            // 
            // cocktailDownText
            // 
            this.cocktailDownText.Location = new System.Drawing.Point(306, 290);
            this.cocktailDownText.Name = "cocktailDownText";
            this.cocktailDownText.ReadOnly = true;
            this.cocktailDownText.Size = new System.Drawing.Size(100, 20);
            this.cocktailDownText.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(46, 297);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(254, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Результат работы сортировки перемешиванием";
            // 
            // arrDownText
            // 
            this.arrDownText.Location = new System.Drawing.Point(306, 264);
            this.arrDownText.Name = "arrDownText";
            this.arrDownText.ReadOnly = true;
            this.arrDownText.Size = new System.Drawing.Size(100, 20);
            this.arrDownText.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(46, 271);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(224, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Массив - убывающая последовательность";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.countSwapHeapDownText);
            this.Controls.Add(this.countSwapCocDownText);
            this.Controls.Add(this.countCompHeapDownText);
            this.Controls.Add(this.countCompCocDownText);
            this.Controls.Add(this.heapDownText);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cocktailDownText);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.arrDownText);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.countSwapHeapUpText);
            this.Controls.Add(this.countSwapCocUpText);
            this.Controls.Add(this.countCompHeapUpText);
            this.Controls.Add(this.countCompCocUpText);
            this.Controls.Add(this.heapUpText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cocktailUpText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.arrUpText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.countSwapHeapText);
            this.Controls.Add(this.countSwapCocText);
            this.Controls.Add(this.countCompHeapText);
            this.Controls.Add(this.countCompCocText);
            this.Controls.Add(this.button);
            this.Controls.Add(this.heapText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cocktailText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizeText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sizeText;
        private System.Windows.Forms.TextBox arrText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cocktailText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox heapText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox countCompCocText;
        private System.Windows.Forms.TextBox countCompHeapText;
        private System.Windows.Forms.TextBox countSwapCocText;
        private System.Windows.Forms.TextBox countSwapHeapText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox countSwapHeapUpText;
        private System.Windows.Forms.TextBox countSwapCocUpText;
        private System.Windows.Forms.TextBox countCompCocUpText;
        private System.Windows.Forms.TextBox heapUpText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cocktailUpText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox arrUpText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox countSwapHeapDownText;
        private System.Windows.Forms.TextBox countSwapCocDownText;
        private System.Windows.Forms.TextBox countCompHeapDownText;
        private System.Windows.Forms.TextBox countCompCocDownText;
        private System.Windows.Forms.TextBox heapDownText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cocktailDownText;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox arrDownText;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox countCompHeapUpText;
    }
}

