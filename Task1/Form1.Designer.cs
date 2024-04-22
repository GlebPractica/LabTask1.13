namespace Task1
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.BttnStart = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.Answ1 = new System.Windows.Forms.Button();
            this.Answ2 = new System.Windows.Forms.Button();
            this.Answ3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BttnStart
            // 
            this.BttnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BttnStart.Location = new System.Drawing.Point(12, 146);
            this.BttnStart.Name = "BttnStart";
            this.BttnStart.Size = new System.Drawing.Size(560, 40);
            this.BttnStart.TabIndex = 0;
            this.BttnStart.Text = "Start";
            this.BttnStart.UseVisualStyleBackColor = true;
            this.BttnStart.Click += new System.EventHandler(this.BttnStart_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(268, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(34, 13);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "00:00";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 43);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(44, 13);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Вопрос";
            // 
            // Answ1
            // 
            this.Answ1.Location = new System.Drawing.Point(160, 81);
            this.Answ1.Name = "Answ1";
            this.Answ1.Size = new System.Drawing.Size(250, 30);
            this.Answ1.TabIndex = 3;
            this.Answ1.Text = "button1";
            this.Answ1.UseVisualStyleBackColor = true;
            // 
            // Answ2
            // 
            this.Answ2.Location = new System.Drawing.Point(160, 117);
            this.Answ2.Name = "Answ2";
            this.Answ2.Size = new System.Drawing.Size(250, 30);
            this.Answ2.TabIndex = 4;
            this.Answ2.Text = "button2";
            this.Answ2.UseVisualStyleBackColor = true;
            // 
            // Answ3
            // 
            this.Answ3.Location = new System.Drawing.Point(160, 153);
            this.Answ3.Name = "Answ3";
            this.Answ3.Size = new System.Drawing.Size(250, 30);
            this.Answ3.TabIndex = 5;
            this.Answ3.Text = "button3";
            this.Answ3.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 338);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(584, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Answ3);
            this.Controls.Add(this.Answ2);
            this.Controls.Add(this.Answ1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.BttnStart);
            this.Name = "Form1";
            this.Text = "Задание";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button BttnStart;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button Answ1;
        private System.Windows.Forms.Button Answ2;
        private System.Windows.Forms.Button Answ3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

