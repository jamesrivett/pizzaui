namespace PizzariaUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.newCust = new System.Windows.Forms.Button();
            this.returnCust = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "JORGE CABALLERO";
            this.label1.Click += new System.EventHandler(this.newCust_Click);
            // 
            // newCust
            // 
            this.newCust.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCust.Location = new System.Drawing.Point(16, 133);
            this.newCust.Margin = new System.Windows.Forms.Padding(4);
            this.newCust.Name = "newCust";
            this.newCust.Size = new System.Drawing.Size(269, 50);
            this.newCust.TabIndex = 1;
            this.newCust.Text = "NEW CUSTOMER";
            this.newCust.UseVisualStyleBackColor = true;
            this.newCust.Click += new System.EventHandler(this.newCust_Click);
            // 
            // returnCust
            // 
            this.returnCust.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnCust.Location = new System.Drawing.Point(16, 202);
            this.returnCust.Margin = new System.Windows.Forms.Padding(4);
            this.returnCust.Name = "returnCust";
            this.returnCust.Size = new System.Drawing.Size(269, 50);
            this.returnCust.TabIndex = 2;
            this.returnCust.Text = "RETURNING CUSTOMER";
            this.returnCust.UseVisualStyleBackColor = true;
            this.returnCust.Click += new System.EventHandler(this.returnCust_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 226);
            this.Controls.Add(this.returnCust);
            this.Controls.Add(this.newCust);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newCust;
        private System.Windows.Forms.Button returnCust;
    }
}

