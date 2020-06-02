namespace Task3
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
            this.x_label = new System.Windows.Forms.Label();
            this.xText = new System.Windows.Forms.TextBox();
            this.yText = new System.Windows.Forms.TextBox();
            this.y_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(237, 226);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 0;
            this.button.Text = "Готово";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // x_label
            // 
            this.x_label.AutoSize = true;
            this.x_label.Location = new System.Drawing.Point(77, 131);
            this.x_label.Name = "x_label";
            this.x_label.Size = new System.Drawing.Size(12, 13);
            this.x_label.TabIndex = 1;
            this.x_label.Text = "x";
            // 
            // xText
            // 
            this.xText.Location = new System.Drawing.Point(95, 131);
            this.xText.Name = "xText";
            this.xText.Size = new System.Drawing.Size(100, 20);
            this.xText.TabIndex = 2;
            this.xText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // yText
            // 
            this.yText.Location = new System.Drawing.Point(95, 181);
            this.yText.Name = "yText";
            this.yText.Size = new System.Drawing.Size(100, 20);
            this.yText.TabIndex = 4;
            this.yText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // y_label
            // 
            this.y_label.AutoSize = true;
            this.y_label.Location = new System.Drawing.Point(77, 184);
            this.y_label.Name = "y_label";
            this.y_label.Size = new System.Drawing.Size(12, 13);
            this.y_label.TabIndex = 3;
            this.y_label.Text = "y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вывод";
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(318, 135);
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(100, 20);
            this.answer.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yText);
            this.Controls.Add(this.y_label);
            this.Controls.Add(this.xText);
            this.Controls.Add(this.x_label);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label x_label;
        private System.Windows.Forms.TextBox xText;
        private System.Windows.Forms.TextBox yText;
        private System.Windows.Forms.Label y_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox answer;
    }
}

