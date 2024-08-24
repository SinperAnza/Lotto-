namespace Lotto_
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
            this.components = new System.ComponentModel.Container();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber3 = new System.Windows.Forms.TextBox();
            this.txtNumber4 = new System.Windows.Forms.TextBox();
            this.txtNumber5 = new System.Windows.Forms.TextBox();
            this.txtNumber6 = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblGuesses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(57, 103);
            this.txtNumber1.MaxLength = 2;
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 22);
            this.txtNumber1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtNumber1, "Enter a number a number between 1 and 45");
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(211, 104);
            this.txtNumber2.MaxLength = 2;
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 22);
            this.txtNumber2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNumber2, "Enter anumber between 1 and 45");
            this.txtNumber2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNumber3
            // 
            this.txtNumber3.Location = new System.Drawing.Point(359, 104);
            this.txtNumber3.MaxLength = 2;
            this.txtNumber3.Name = "txtNumber3";
            this.txtNumber3.Size = new System.Drawing.Size(100, 22);
            this.txtNumber3.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtNumber3, "Enter a number between 1 and 45");
            // 
            // txtNumber4
            // 
            this.txtNumber4.Location = new System.Drawing.Point(525, 104);
            this.txtNumber4.MaxLength = 2;
            this.txtNumber4.Name = "txtNumber4";
            this.txtNumber4.Size = new System.Drawing.Size(100, 22);
            this.txtNumber4.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtNumber4, "Enter a number between 1 and 45 ");
            // 
            // txtNumber5
            // 
            this.txtNumber5.Location = new System.Drawing.Point(717, 103);
            this.txtNumber5.MaxLength = 2;
            this.txtNumber5.Name = "txtNumber5";
            this.txtNumber5.Size = new System.Drawing.Size(100, 22);
            this.txtNumber5.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtNumber5, "Enter a number between 1 and 45 ");
            // 
            // txtNumber6
            // 
            this.txtNumber6.Location = new System.Drawing.Point(886, 103);
            this.txtNumber6.MaxLength = 2;
            this.txtNumber6.Name = "txtNumber6";
            this.txtNumber6.Size = new System.Drawing.Size(100, 22);
            this.txtNumber6.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtNumber6, "Enter a number between 1 and 45 ");
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(104, 336);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(177, 39);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Guess ";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Reset ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(569, 234);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(7, 16);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(859, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(572, 254);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(0, 16);
            this.lblCost.TabIndex = 10;
            // 
            // lblGuesses
            // 
            this.lblGuesses.AutoSize = true;
            this.lblGuesses.Location = new System.Drawing.Point(313, 253);
            this.lblGuesses.Name = "lblGuesses";
            this.lblGuesses.Size = new System.Drawing.Size(0, 16);
            this.lblGuesses.TabIndex = 11;
            this.lblGuesses.Click += new System.EventHandler(this.lblGuesses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 450);
            this.Controls.Add(this.lblGuesses);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtNumber6);
            this.Controls.Add(this.txtNumber5);
            this.Controls.Add(this.txtNumber4);
            this.Controls.Add(this.txtNumber3);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber3;
        private System.Windows.Forms.TextBox txtNumber4;
        private System.Windows.Forms.TextBox txtNumber5;
        private System.Windows.Forms.TextBox txtNumber6;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblGuesses;
    }
}

