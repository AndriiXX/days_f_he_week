namespace days_f_he_eek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCheckDay = new Button();
            tbInputDate = new TextBox();
            tbResult = new TextBox();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCheckDay
            // 
            btnCheckDay.Location = new Point(540, 257);
            btnCheckDay.Name = "btnCheckDay";
            btnCheckDay.Size = new Size(75, 23);
            btnCheckDay.TabIndex = 0;
            btnCheckDay.Text = "Результат";
            btnCheckDay.UseVisualStyleBackColor = true;
            btnCheckDay.Click += btnCheckDay_Click;
            // 
            // tbInputDate
            // 
            tbInputDate.Location = new Point(252, 228);
            tbInputDate.Name = "tbInputDate";
            tbInputDate.Size = new Size(100, 23);
            tbInputDate.TabIndex = 1;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(454, 228);
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(256, 23);
            tbResult.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 231);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 3;
            label1.Text = "Введіть Дату :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 257);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 5;
            label3.Text = "в форматі : (00.00.0000)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(tbResult);
            Controls.Add(tbInputDate);
            Controls.Add(btnCheckDay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCheckDay;
        private TextBox tbInputDate;
        private TextBox tbResult;
        private Label label1;
        private Label label3;
    }
}
