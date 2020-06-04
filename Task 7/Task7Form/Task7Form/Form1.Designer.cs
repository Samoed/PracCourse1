namespace Task7Form
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
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.sizeButton = new System.Windows.Forms.Button();
            this.tableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Введите количество символов";
            // 
            // sizeText
            // 
            this.sizeText.Location = new System.Drawing.Point(185, 78);
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(100, 20);
            this.sizeText.TabIndex = 1;
            this.sizeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressInt);
            // 
            // table
            // 
            this.table.AutoSize = true;
            this.table.ColumnCount = 3;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.table.Location = new System.Drawing.Point(16, 116);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.Size = new System.Drawing.Size(361, 47);
            this.table.TabIndex = 2;
            // 
            // sizeButton
            // 
            this.sizeButton.Location = new System.Drawing.Point(291, 78);
            this.sizeButton.Name = "sizeButton";
            this.sizeButton.Size = new System.Drawing.Size(75, 19);
            this.sizeButton.TabIndex = 3;
            this.sizeButton.Text = "Готово";
            this.sizeButton.UseVisualStyleBackColor = true;
            this.sizeButton.Click += new System.EventHandler(this.sizeButton_Click);
            // 
            // tableButton
            // 
            this.tableButton.Location = new System.Drawing.Point(384, 116);
            this.tableButton.Name = "tableButton";
            this.tableButton.Size = new System.Drawing.Size(75, 23);
            this.tableButton.TabIndex = 4;
            this.tableButton.Text = "Готово";
            this.tableButton.UseVisualStyleBackColor = true;
            this.tableButton.Click += new System.EventHandler(this.tableButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableButton);
            this.Controls.Add(this.sizeButton);
            this.Controls.Add(this.table);
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
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Button sizeButton;
        private System.Windows.Forms.Button tableButton;
    }
}

