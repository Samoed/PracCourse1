namespace Task9Form
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
            this.initButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.initText = new System.Windows.Forms.TextBox();
            this.findText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.arrText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // initButton
            // 
            this.initButton.Location = new System.Drawing.Point(293, 73);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(75, 23);
            this.initButton.TabIndex = 0;
            this.initButton.Text = "Создать";
            this.initButton.UseVisualStyleBackColor = true;
            this.initButton.Click += new System.EventHandler(this.initButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите размер";
            // 
            // initText
            // 
            this.initText.Location = new System.Drawing.Point(187, 75);
            this.initText.Name = "initText";
            this.initText.Size = new System.Drawing.Size(100, 20);
            this.initText.TabIndex = 2;
            this.initText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // findText
            // 
            this.findText.Location = new System.Drawing.Point(187, 101);
            this.findText.Name = "findText";
            this.findText.Size = new System.Drawing.Size(100, 20);
            this.findText.TabIndex = 4;
            this.findText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Элемент который надо найти";
            // 
            // delText
            // 
            this.delText.Location = new System.Drawing.Point(187, 127);
            this.delText.Name = "delText";
            this.delText.Size = new System.Drawing.Size(100, 20);
            this.delText.TabIndex = 6;
            this.delText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Элемент для удаления";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(293, 99);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 7;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(293, 125);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Массив";
            // 
            // arrText
            // 
            this.arrText.Location = new System.Drawing.Point(428, 99);
            this.arrText.Name = "arrText";
            this.arrText.ReadOnly = true;
            this.arrText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.arrText.Size = new System.Drawing.Size(110, 20);
            this.arrText.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.arrText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.delText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.findText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.initText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.initButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button initButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox initText;
        private System.Windows.Forms.TextBox findText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox delText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox arrText;
    }
}

