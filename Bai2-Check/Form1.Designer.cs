namespace Bai2_Check
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
            this.lb1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb3 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(13, 13);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(44, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "IP/Host";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(64, 5);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(244, 20);
            this.txt1.TabIndex = 1;
            this.txt1.Text = "127.0.0.1";
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(315, 11);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(26, 13);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Port";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(348, 5);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(154, 20);
            this.txt2.TabIndex = 3;
            this.txt2.Text = "1724";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(489, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(13, 92);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(37, 13);
            this.lb3.TabIndex = 5;
            this.lb3.Text = "Result";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(12, 108);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(490, 20);
            this.txt3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 168);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btn1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.TextBox txt3;
    }
}

