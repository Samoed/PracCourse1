namespace Task6Form
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
            this.a1Text = new System.Windows.Forms.TextBox();
            this.a2Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.a3Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ansCompare = new System.Windows.Forms.Label();
            this.jAns = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(278, 362);
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
            this.label1.Location = new System.Drawing.Point(49, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a1";
            // 
            // a1Text
            // 
            this.a1Text.Location = new System.Drawing.Point(91, 77);
            this.a1Text.Name = "a1Text";
            this.a1Text.Size = new System.Drawing.Size(100, 20);
            this.a1Text.TabIndex = 2;
            this.a1Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // a2Text
            // 
            this.a2Text.Location = new System.Drawing.Point(91, 103);
            this.a2Text.Name = "a2Text";
            this.a2Text.Size = new System.Drawing.Size(100, 20);
            this.a2Text.TabIndex = 4;
            this.a2Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "a2";
            // 
            // a3Text
            // 
            this.a3Text.Location = new System.Drawing.Point(91, 129);
            this.a3Text.Name = "a3Text";
            this.a3Text.Size = new System.Drawing.Size(100, 20);
            this.a3Text.TabIndex = 6;
            this.a3Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "a3";
            // 
            // mText
            // 
            this.mText.Location = new System.Drawing.Point(91, 155);
            this.mText.Name = "mText";
            this.mText.Size = new System.Drawing.Size(100, 20);
            this.mText.TabIndex = 8;
            this.mText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "M";
            // 
            // nText
            // 
            this.nText.Location = new System.Drawing.Point(91, 181);
            this.nText.Name = "nText";
            this.nText.Size = new System.Drawing.Size(100, 20);
            this.nText.TabIndex = 10;
            this.nText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "N";
            // 
            // ansCompare
            // 
            this.ansCompare.AutoSize = true;
            this.ansCompare.Location = new System.Drawing.Point(254, 110);
            this.ansCompare.Name = "ansCompare";
            this.ansCompare.Size = new System.Drawing.Size(0, 13);
            this.ansCompare.TabIndex = 13;
            // 
            // jAns
            // 
            this.jAns.AutoSize = true;
            this.jAns.Location = new System.Drawing.Point(257, 76);
            this.jAns.Name = "jAns";
            this.jAns.Size = new System.Drawing.Size(0, 13);
            this.jAns.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Последовательность";
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(382, 135);
            this.order.Multiline = true;
            this.order.Name = "order";
            this.order.ReadOnly = true;
            this.order.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.order.Size = new System.Drawing.Size(181, 78);
            this.order.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.order);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.jAns);
            this.Controls.Add(this.ansCompare);
            this.Controls.Add(this.nText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.a3Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.a2Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.a1Text);
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
        private System.Windows.Forms.TextBox a1Text;
        private System.Windows.Forms.TextBox a2Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox a3Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ansCompare;
        private System.Windows.Forms.Label jAns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox order;
    }
}

