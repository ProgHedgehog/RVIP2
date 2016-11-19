namespace _4laba
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.number_of_documentsn_ud = new System.Windows.Forms.NumericUpDown();
            this.Printbtn = new System.Windows.Forms.Button();
            this.text_log = new System.Windows.Forms.TextBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_documentsn_ud)).BeginInit();
            this.SuspendLayout();
            // 
            // number_of_documentsn_ud
            // 
            this.number_of_documentsn_ud.Location = new System.Drawing.Point(13, 13);
            this.number_of_documentsn_ud.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.number_of_documentsn_ud.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.number_of_documentsn_ud.Name = "number_of_documentsn_ud";
            this.number_of_documentsn_ud.Size = new System.Drawing.Size(59, 20);
            this.number_of_documentsn_ud.TabIndex = 0;
            this.number_of_documentsn_ud.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Printbtn
            // 
            this.Printbtn.Location = new System.Drawing.Point(13, 264);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.Size = new System.Drawing.Size(122, 42);
            this.Printbtn.TabIndex = 1;
            this.Printbtn.Text = "Сохранить";
            this.Printbtn.UseVisualStyleBackColor = true;
            this.Printbtn.Click += new System.EventHandler(this.Printbtn_Click);
            // 
            // text_log
            // 
            this.text_log.Location = new System.Drawing.Point(12, 39);
            this.text_log.Multiline = true;
            this.text_log.Name = "text_log";
            this.text_log.Size = new System.Drawing.Size(250, 219);
            this.text_log.TabIndex = 2;
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(140, 264);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(122, 42);
            this.StopBtn.TabIndex = 4;
            this.StopBtn.Text = "Отменить сохранение";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Задать число потоков";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.text_log);
            this.Controls.Add(this.Printbtn);
            this.Controls.Add(this.number_of_documentsn_ud);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Многопоточность";
            ((System.ComponentModel.ISupportInitialize)(this.number_of_documentsn_ud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown number_of_documentsn_ud;
        private System.Windows.Forms.Button Printbtn;
        public System.Windows.Forms.TextBox text_log;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Label label1;
    }
}

