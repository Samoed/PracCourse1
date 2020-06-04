namespace Task10Form
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
            this.button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeText = new System.Windows.Forms.TextBox();
            this.arrText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ansText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(181, 194);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 0;
            this.button.Text = "Готово";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите размер массива";
            // 
            // sizeText
            // 
            this.sizeText.Location = new System.Drawing.Point(156, 97);
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(100, 20);
            this.sizeText.TabIndex = 2;
            this.sizeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // arrText
            // 
            this.arrText.Location = new System.Drawing.Point(156, 123);
            this.arrText.Name = "arrText";
            this.arrText.ReadOnly = true;
            this.arrText.Size = new System.Drawing.Size(100, 20);
            this.arrText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Массив";
            // 
            // ansText
            // 
            this.ansText.Location = new System.Drawing.Point(156, 149);
            this.ansText.Name = "ansText";
            this.ansText.ReadOnly = true;
            this.ansText.Size = new System.Drawing.Size(100, 20);
            this.ansText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ansText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sizeText;
        private System.Windows.Forms.TextBox arrText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ansText;
        private System.Windows.Forms.Label label3;
    }
}

