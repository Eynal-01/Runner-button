namespace Tom_jerry
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
            this.jerrybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jerrybtn
            // 
            this.jerrybtn.BackColor = System.Drawing.Color.Red;
            this.jerrybtn.Location = new System.Drawing.Point(111, 68);
            this.jerrybtn.Name = "jerrybtn";
            this.jerrybtn.Size = new System.Drawing.Size(57, 56);
            this.jerrybtn.TabIndex = 0;
            this.jerrybtn.UseVisualStyleBackColor = false;
            this.jerrybtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.jerrybtn_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(958, 501);
            this.Controls.Add(this.jerrybtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jerrybtn;
    }
}

