namespace Calculator
{
    partial class frmCalculator
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
            this.txtG2 = new System.Windows.Forms.TextBox();
            this.txtG3 = new System.Windows.Forms.TextBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.txtG1 = new System.Windows.Forms.TextBox();
            this.txtG5 = new System.Windows.Forms.TextBox();
            this.txtG4 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblG1 = new System.Windows.Forms.Label();
            this.lblG2 = new System.Windows.Forms.Label();
            this.lblG3 = new System.Windows.Forms.Label();
            this.lblG4 = new System.Windows.Forms.Label();
            this.lblG5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtG2
            // 
            this.txtG2.Location = new System.Drawing.Point(123, 50);
            this.txtG2.Name = "txtG2";
            this.txtG2.Size = new System.Drawing.Size(182, 20);
            this.txtG2.TabIndex = 0;
            // 
            // txtG3
            // 
            this.txtG3.Location = new System.Drawing.Point(123, 76);
            this.txtG3.Name = "txtG3";
            this.txtG3.Size = new System.Drawing.Size(182, 20);
            this.txtG3.TabIndex = 1;
            // 
            // lblOut
            // 
            this.lblOut.Location = new System.Drawing.Point(29, 154);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(241, 85);
            this.lblOut.TabIndex = 4;
            this.lblOut.Click += new System.EventHandler(this.lblOut_Click);
            // 
            // txtG1
            // 
            this.txtG1.Location = new System.Drawing.Point(123, 24);
            this.txtG1.Name = "txtG1";
            this.txtG1.Size = new System.Drawing.Size(182, 20);
            this.txtG1.TabIndex = 5;
            // 
            // txtG5
            // 
            this.txtG5.Location = new System.Drawing.Point(123, 128);
            this.txtG5.Name = "txtG5";
            this.txtG5.Size = new System.Drawing.Size(182, 20);
            this.txtG5.TabIndex = 6;
            // 
            // txtG4
            // 
            this.txtG4.Location = new System.Drawing.Point(123, 102);
            this.txtG4.Name = "txtG4";
            this.txtG4.Size = new System.Drawing.Size(182, 20);
            this.txtG4.TabIndex = 7;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(82, 242);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(138, 46);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Get Average";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblG1
            // 
            this.lblG1.AutoSize = true;
            this.lblG1.Location = new System.Drawing.Point(9, 27);
            this.lblG1.Name = "lblG1";
            this.lblG1.Size = new System.Drawing.Size(45, 13);
            this.lblG1.TabIndex = 10;
            this.lblG1.Text = "Grade 1";
            // 
            // lblG2
            // 
            this.lblG2.AutoSize = true;
            this.lblG2.Location = new System.Drawing.Point(9, 53);
            this.lblG2.Name = "lblG2";
            this.lblG2.Size = new System.Drawing.Size(45, 13);
            this.lblG2.TabIndex = 11;
            this.lblG2.Text = "Grade 2";
            // 
            // lblG3
            // 
            this.lblG3.AutoSize = true;
            this.lblG3.Location = new System.Drawing.Point(9, 83);
            this.lblG3.Name = "lblG3";
            this.lblG3.Size = new System.Drawing.Size(45, 13);
            this.lblG3.TabIndex = 12;
            this.lblG3.Text = "Grade 3";
            // 
            // lblG4
            // 
            this.lblG4.AutoSize = true;
            this.lblG4.Location = new System.Drawing.Point(9, 109);
            this.lblG4.Name = "lblG4";
            this.lblG4.Size = new System.Drawing.Size(45, 13);
            this.lblG4.TabIndex = 13;
            this.lblG4.Text = "Grade 4";
            // 
            // lblG5
            // 
            this.lblG5.AutoSize = true;
            this.lblG5.Location = new System.Drawing.Point(9, 135);
            this.lblG5.Name = "lblG5";
            this.lblG5.Size = new System.Drawing.Size(45, 13);
            this.lblG5.TabIndex = 14;
            this.lblG5.Text = "Grade 5";
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 310);
            this.Controls.Add(this.lblG5);
            this.Controls.Add(this.lblG4);
            this.Controls.Add(this.lblG3);
            this.Controls.Add(this.lblG2);
            this.Controls.Add(this.lblG1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtG4);
            this.Controls.Add(this.txtG5);
            this.Controls.Add(this.txtG1);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.txtG3);
            this.Controls.Add(this.txtG2);
            this.Name = "frmCalculator";
            this.Text = "I Do Your Math";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtG2;
        private System.Windows.Forms.TextBox txtG3;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.TextBox txtG1;
        private System.Windows.Forms.TextBox txtG5;
        private System.Windows.Forms.TextBox txtG4;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblG1;
        private System.Windows.Forms.Label lblG2;
        private System.Windows.Forms.Label lblG3;
        private System.Windows.Forms.Label lblG4;
        private System.Windows.Forms.Label lblG5;
    }
}

