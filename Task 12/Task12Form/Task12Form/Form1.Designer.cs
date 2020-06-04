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
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Массив";
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
            this.button.Location = new System.Drawing.Point(331, 208);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 8;
            this.button.Text = "Готово";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

