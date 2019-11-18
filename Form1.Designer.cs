namespace MyProject
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
            this.Button = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Button.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Button.Location = new System.Drawing.Point(448, 10);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(133, 47);
            this.Button.TabIndex = 6;
            this.Button.Text = "Click";
            this.Button.Click += new System.EventHandler(this.ButtonClick);
            // 
            // input
            // 
            this.Input.Location = new System.Drawing.Point(12, 12);
            this.Input.MaxLength = 3116;
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(429, 45);
            this.Input.TabIndex = 3;
            // 
            // Image
            // 
            this.Image.BackColor = System.Drawing.Color.White;
            this.Image.Location = new System.Drawing.Point(12, 63);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(569, 571);
            this.Image.TabIndex = 5;
            this.Image.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(606, 646);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Datamatrix Generator";
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.PictureBox Image;
    }
}

