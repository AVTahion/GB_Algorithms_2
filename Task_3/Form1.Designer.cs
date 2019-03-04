namespace Task_3
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
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.btnMultiply2 = new System.Windows.Forms.Button();
            this.tBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(12, 67);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(93, 23);
            this.btnAdd1.TabIndex = 1;
            this.btnAdd1.Text = "Прибавь 1";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // btnMultiply2
            // 
            this.btnMultiply2.Location = new System.Drawing.Point(111, 67);
            this.btnMultiply2.Name = "btnMultiply2";
            this.btnMultiply2.Size = new System.Drawing.Size(93, 23);
            this.btnMultiply2.TabIndex = 2;
            this.btnMultiply2.Text = "Умножь на 2";
            this.btnMultiply2.UseVisualStyleBackColor = true;
            this.btnMultiply2.Click += new System.EventHandler(this.btnMultiply2_Click);
            // 
            // tBox
            // 
            this.tBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBox.Location = new System.Drawing.Point(12, 12);
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(192, 49);
            this.tBox.TabIndex = 0;
            this.tBox.Text = "0";
            this.tBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 106);
            this.Controls.Add(this.btnMultiply2);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.tBox);
            this.Name = "Form1";
            this.Text = "\"Калькулятор\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Button btnMultiply2;
    }
}

