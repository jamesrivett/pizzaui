namespace PizzariaUI
{
    partial class Account_Details
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(880, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "Deals";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1068, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 77);
            this.button3.TabIndex = 2;
            this.button3.Text = "Order History";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1256, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 77);
            this.button4.TabIndex = 3;
            this.button4.Text = "Account Details";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(75, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1218, 103);
            this.label1.TabIndex = 4;
            this.label1.Text = "ACCOUNT DETAILS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(520, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(912, 36);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Cardholder\'s Name ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(520, 247);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(788, 22);
            this.textBox2.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1314, 247);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Account_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 758);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Account_Details";
            this.Text = "Account_Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
    }
}