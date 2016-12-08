namespace Projet_GenieLog
{
    partial class MyMessageBox
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
            this.lettre1LB = new System.Windows.Forms.Label();
            this.lettre2LB = new System.Windows.Forms.Label();
            this.lettre3LB = new System.Windows.Forms.Label();
            this.lettre4LB = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.validButton = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lettre1LB
            // 
            this.lettre1LB.AutoSize = true;
            this.lettre1LB.Location = new System.Drawing.Point(37, 84);
            this.lettre1LB.Name = "lettre1LB";
            this.lettre1LB.Size = new System.Drawing.Size(46, 17);
            this.lettre1LB.TabIndex = 0;
            this.lettre1LB.Text = "label1";
            // 
            // lettre2LB
            // 
            this.lettre2LB.AutoSize = true;
            this.lettre2LB.Location = new System.Drawing.Point(158, 84);
            this.lettre2LB.Name = "lettre2LB";
            this.lettre2LB.Size = new System.Drawing.Size(46, 17);
            this.lettre2LB.TabIndex = 1;
            this.lettre2LB.Text = "label2";
            // 
            // lettre3LB
            // 
            this.lettre3LB.AutoSize = true;
            this.lettre3LB.Location = new System.Drawing.Point(268, 84);
            this.lettre3LB.Name = "lettre3LB";
            this.lettre3LB.Size = new System.Drawing.Size(46, 17);
            this.lettre3LB.TabIndex = 2;
            this.lettre3LB.Text = "label3";
            // 
            // lettre4LB
            // 
            this.lettre4LB.AutoSize = true;
            this.lettre4LB.Location = new System.Drawing.Point(381, 84);
            this.lettre4LB.Name = "lettre4LB";
            this.lettre4LB.Size = new System.Drawing.Size(46, 17);
            this.lettre4LB.TabIndex = 3;
            this.lettre4LB.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(262, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(61, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(375, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(61, 22);
            this.textBox4.TabIndex = 7;
            // 
            // validButton
            // 
            this.validButton.Location = new System.Drawing.Point(339, 297);
            this.validButton.Name = "validButton";
            this.validButton.Size = new System.Drawing.Size(75, 23);
            this.validButton.TabIndex = 8;
            this.validButton.Text = "Valider";
            this.validButton.UseVisualStyleBackColor = true;
            this.validButton.Click += new System.EventHandler(this.validButton_Click);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(407, 362);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(67, 17);
            this.count.TabIndex = 10;
            this.count.Text = "compteur";
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 388);
            this.Controls.Add(this.count);
            this.Controls.Add(this.validButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lettre4LB);
            this.Controls.Add(this.lettre3LB);
            this.Controls.Add(this.lettre2LB);
            this.Controls.Add(this.lettre1LB);
            this.Name = "MyMessageBox";
            this.Text = "MyMessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lettre1LB;
        private System.Windows.Forms.Label lettre2LB;
        private System.Windows.Forms.Label lettre3LB;
        private System.Windows.Forms.Label lettre4LB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button validButton;
        private System.Windows.Forms.Label count;
    }
}