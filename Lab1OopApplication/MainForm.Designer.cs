namespace Lab1OopApplication
{
    partial class MainForm
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
            this.InputFirstNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InputSecondNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SumOperButton = new System.Windows.Forms.Button();
            this.SubtractionOperButton = new System.Windows.Forms.Button();
            this.ExtentOerpButton = new System.Windows.Forms.Button();
            this.ComparisonOperButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CounterTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputFirstNumberTextBox
            // 
            this.InputFirstNumberTextBox.Location = new System.Drawing.Point(12, 36);
            this.InputFirstNumberTextBox.Name = "InputFirstNumberTextBox";
            this.InputFirstNumberTextBox.Size = new System.Drawing.Size(106, 20);
            this.InputFirstNumberTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите числа";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // InputSecondNumberTextBox
            // 
            this.InputSecondNumberTextBox.Location = new System.Drawing.Point(135, 36);
            this.InputSecondNumberTextBox.Name = "InputSecondNumberTextBox";
            this.InputSecondNumberTextBox.Size = new System.Drawing.Size(109, 20);
            this.InputSecondNumberTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите операцию";
            // 
            // SumOperButton
            // 
            this.SumOperButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SumOperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumOperButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SumOperButton.Location = new System.Drawing.Point(16, 85);
            this.SumOperButton.Name = "SumOperButton";
            this.SumOperButton.Size = new System.Drawing.Size(35, 29);
            this.SumOperButton.TabIndex = 5;
            this.SumOperButton.Tag = "+";
            this.SumOperButton.Text = "+\r\n";
            this.SumOperButton.UseVisualStyleBackColor = false;
            this.SumOperButton.Click += new System.EventHandler(this.OperButton_Click);
            // 
            // SubtractionOperButton
            // 
            this.SubtractionOperButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SubtractionOperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubtractionOperButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubtractionOperButton.Location = new System.Drawing.Point(57, 85);
            this.SubtractionOperButton.Name = "SubtractionOperButton";
            this.SubtractionOperButton.Size = new System.Drawing.Size(35, 29);
            this.SubtractionOperButton.TabIndex = 6;
            this.SubtractionOperButton.Tag = "-";
            this.SubtractionOperButton.Text = "-";
            this.SubtractionOperButton.UseVisualStyleBackColor = false;
            this.SubtractionOperButton.Click += new System.EventHandler(this.OperButton_Click);
            // 
            // ExtentOerpButton
            // 
            this.ExtentOerpButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExtentOerpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtentOerpButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExtentOerpButton.Location = new System.Drawing.Point(98, 85);
            this.ExtentOerpButton.Name = "ExtentOerpButton";
            this.ExtentOerpButton.Size = new System.Drawing.Size(35, 29);
            this.ExtentOerpButton.TabIndex = 7;
            this.ExtentOerpButton.Tag = "^";
            this.ExtentOerpButton.Text = "^";
            this.ExtentOerpButton.UseVisualStyleBackColor = false;
            this.ExtentOerpButton.Click += new System.EventHandler(this.OperButton_Click);
            // 
            // ComparisonOperButton
            // 
            this.ComparisonOperButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ComparisonOperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComparisonOperButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComparisonOperButton.Location = new System.Drawing.Point(139, 85);
            this.ComparisonOperButton.Name = "ComparisonOperButton";
            this.ComparisonOperButton.Size = new System.Drawing.Size(72, 29);
            this.ComparisonOperButton.TabIndex = 8;
            this.ComparisonOperButton.Tag = "<>";
            this.ComparisonOperButton.Text = "сравнить";
            this.ComparisonOperButton.UseVisualStyleBackColor = false;
            this.ComparisonOperButton.Click += new System.EventHandler(this.OperButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Счетчик операций";
            // 
            // CounterTextBox
            // 
            this.CounterTextBox.Location = new System.Drawing.Point(407, 36);
            this.CounterTextBox.Name = "CounterTextBox";
            this.CounterTextBox.ReadOnly = true;
            this.CounterTextBox.Size = new System.Drawing.Size(54, 20);
            this.CounterTextBox.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 137);
            this.Controls.Add(this.CounterTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComparisonOperButton);
            this.Controls.Add(this.ExtentOerpButton);
            this.Controls.Add(this.SubtractionOperButton);
            this.Controls.Add(this.SumOperButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputSecondNumberTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputFirstNumberTextBox);
            this.Name = "MainForm";
            this.Text = "Небыловский ЛА, ЭБЦ-211, ПР 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputFirstNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox InputSecondNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SumOperButton;
        private System.Windows.Forms.Button SubtractionOperButton;
        private System.Windows.Forms.Button ExtentOerpButton;
        private System.Windows.Forms.Button ComparisonOperButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CounterTextBox;
    }
}

