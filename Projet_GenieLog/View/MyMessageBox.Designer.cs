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
            this.components = new System.ComponentModel.Container();
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
            this.timerAfficheResultat = new System.Windows.Forms.Timer(this.components);
            this.verifLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lettre1LB
            // 
            this.lettre1LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lettre1LB.AutoSize = true;
            this.lettre1LB.Location = new System.Drawing.Point(28, 68);
            this.lettre1LB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lettre1LB.Name = "lettre1LB";
            this.lettre1LB.Size = new System.Drawing.Size(35, 13);
            this.lettre1LB.TabIndex = 0;
            this.lettre1LB.Text = "label1";
            // 
            // lettre2LB
            // 
            this.lettre2LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lettre2LB.AutoSize = true;
            this.lettre2LB.Location = new System.Drawing.Point(118, 68);
            this.lettre2LB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lettre2LB.Name = "lettre2LB";
            this.lettre2LB.Size = new System.Drawing.Size(35, 13);
            this.lettre2LB.TabIndex = 1;
            this.lettre2LB.Text = "label2";
            // 
            // lettre3LB
            // 
            this.lettre3LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lettre3LB.AutoSize = true;
            this.lettre3LB.Location = new System.Drawing.Point(201, 68);
            this.lettre3LB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lettre3LB.Name = "lettre3LB";
            this.lettre3LB.Size = new System.Drawing.Size(35, 13);
            this.lettre3LB.TabIndex = 2;
            this.lettre3LB.Text = "label3";
            // 
            // lettre4LB
            // 
            this.lettre4LB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lettre4LB.AutoSize = true;
            this.lettre4LB.Location = new System.Drawing.Point(286, 68);
            this.lettre4LB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lettre4LB.Name = "lettre4LB";
            this.lettre4LB.Size = new System.Drawing.Size(35, 13);
            this.lettre4LB.TabIndex = 3;
            this.lettre4LB.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(22, 129);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(114, 129);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(196, 129);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(47, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Location = new System.Drawing.Point(281, 129);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(47, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // validButton
            // 
            this.validButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.validButton.Location = new System.Drawing.Point(264, 220);
            this.validButton.Margin = new System.Windows.Forms.Padding(2);
            this.validButton.Name = "validButton";
            this.validButton.Size = new System.Drawing.Size(70, 31);
            this.validButton.TabIndex = 8;
            this.validButton.Text = "Valider";
            this.validButton.UseVisualStyleBackColor = true;
            this.validButton.Click += new System.EventHandler(this.validButton_Click);
            // 
            // count
            // 
            this.count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(305, 294);
            this.count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(51, 13);
            this.count.TabIndex = 10;
            this.count.Text = "compteur";
            // 
            // timerAfficheResultat
            // 
            this.timerAfficheResultat.Tick += new System.EventHandler(this.timerAfficheResultat_Tick);
            // 
            // verifLB
            // 
            this.verifLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.verifLB.AutoSize = true;
            this.verifLB.Location = new System.Drawing.Point(98, 271);
            this.verifLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.verifLB.Name = "verifLB";
            this.verifLB.Size = new System.Drawing.Size(27, 13);
            this.verifLB.TabIndex = 11;
            this.verifLB.Text = "verif";
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 315);
            this.Controls.Add(this.verifLB);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MyMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Timer timerAfficheResultat;
        private System.Windows.Forms.Label verifLB;
    }
}