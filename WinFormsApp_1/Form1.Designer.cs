namespace WinFormsApp_1
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
            this.lblwelcome = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.tbage = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblwelcome.Location = new System.Drawing.Point(117, 22);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(479, 39);
            this.lblwelcome.TabIndex = 0;
            this.lblwelcome.Text = "My First Winforms Application\r\n";
            this.lblwelcome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Lime;
            this.lblname.Location = new System.Drawing.Point(31, 110);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(136, 20);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Enter Your Name ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsubmit.Location = new System.Drawing.Point(35, 169);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(132, 57);
            this.btnsubmit.TabIndex = 3;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // tbage
            // 
            this.tbage.Location = new System.Drawing.Point(218, 133);
            this.tbage.Name = "tbage";
            this.tbage.Size = new System.Drawing.Size(100, 20);
            this.tbage.TabIndex = 4;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.ForeColor = System.Drawing.Color.Lime;
            this.lblage.Location = new System.Drawing.Point(220, 113);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(98, 16);
            this.lblage.TabIndex = 5;
            this.lblage.Text = "Enter Your Age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.tbage);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblwelcome);
            this.Name = "Form1";
            this.Text = "My First Win Form App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.TextBox tbage;
        private System.Windows.Forms.Label lblage;
    }
}

