namespace Projet_GenieLog.View
{
    partial class FormConcentration
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
            this.labelConsigne = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Label();
            this.groupBoxButton = new System.Windows.Forms.GroupBox();
            this.timerConcentration = new System.Windows.Forms.Timer(this.components);
            this.groupBoxButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelConsigne
            // 
            this.labelConsigne.AutoSize = true;
            this.labelConsigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelConsigne.Location = new System.Drawing.Point(9, 49);
            this.labelConsigne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConsigne.MaximumSize = new System.Drawing.Size(375, 431);
            this.labelConsigne.Name = "labelConsigne";
            this.labelConsigne.Size = new System.Drawing.Size(72, 17);
            this.labelConsigne.TabIndex = 0;
            this.labelConsigne.Text = "consignes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 55);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 98);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(433, 386);
            this.count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(51, 13);
            this.count.TabIndex = 10;
            this.count.Text = "compteur";
            // 
            // groupBoxButton
            // 
            this.groupBoxButton.Controls.Add(this.button3);
            this.groupBoxButton.Controls.Add(this.button2);
            this.groupBoxButton.Controls.Add(this.button1);
            this.groupBoxButton.Location = new System.Drawing.Point(344, 148);
            this.groupBoxButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxButton.Name = "groupBoxButton";
            this.groupBoxButton.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxButton.Size = new System.Drawing.Size(88, 133);
            this.groupBoxButton.TabIndex = 11;
            this.groupBoxButton.TabStop = false;
            // 
            // timerConcentration
            // 
            this.timerConcentration.Tick += new System.EventHandler(this.timerConcentration_Tick);
            // 
            // FormConcentration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 407);
            this.Controls.Add(this.groupBoxButton);
            this.Controls.Add(this.labelConsigne);
            this.Controls.Add(this.count);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormConcentration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConcentration";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConcentration_FormClosing);
            this.groupBoxButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConsigne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.GroupBox groupBoxButton;
        private System.Windows.Forms.Timer timerConcentration;
    }
}