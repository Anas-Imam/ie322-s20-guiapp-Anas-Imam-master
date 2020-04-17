namespace MY_FIRST_APP
{
    partial class frmRandom
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
            this.btnGeneraleRandomColor = new System.Windows.Forms.Button();
            this.btnRandomNumber = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblrgb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGeneraleRandomColor
            // 
            this.btnGeneraleRandomColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGeneraleRandomColor.Location = new System.Drawing.Point(242, 38);
            this.btnGeneraleRandomColor.Name = "btnGeneraleRandomColor";
            this.btnGeneraleRandomColor.Size = new System.Drawing.Size(328, 77);
            this.btnGeneraleRandomColor.TabIndex = 0;
            this.btnGeneraleRandomColor.Text = "Generale Random Color";
            this.btnGeneraleRandomColor.UseVisualStyleBackColor = false;
            this.btnGeneraleRandomColor.Click += new System.EventHandler(this.btnGeneraleRandomColor_Click);
            // 
            // btnRandomNumber
            // 
            this.btnRandomNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandomNumber.Location = new System.Drawing.Point(242, 234);
            this.btnRandomNumber.Name = "btnRandomNumber";
            this.btnRandomNumber.Size = new System.Drawing.Size(184, 60);
            this.btnRandomNumber.TabIndex = 0;
            this.btnRandomNumber.Text = "Random Number";
            this.btnRandomNumber.UseVisualStyleBackColor = false;
            this.btnRandomNumber.Click += new System.EventHandler(this.btnRandomNumber_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(604, 378);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(184, 60);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblrgb
            // 
            this.lblrgb.AutoSize = true;
            this.lblrgb.Location = new System.Drawing.Point(387, 136);
            this.lblrgb.Name = "lblrgb";
            this.lblrgb.Size = new System.Drawing.Size(39, 17);
            this.lblrgb.TabIndex = 1;
            this.lblrgb.Text = "r-g-b";
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblrgb);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRandomNumber);
            this.Controls.Add(this.btnGeneraleRandomColor);
            this.Name = "frmRandom";
            this.Text = "frmRandom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneraleRandomColor;
        private System.Windows.Forms.Button btnRandomNumber;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblrgb;
    }
}