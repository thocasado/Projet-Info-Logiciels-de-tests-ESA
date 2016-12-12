namespace Projet_GenieLog.View
{
    partial class FormProbleme
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
            this.rbChoix4 = new System.Windows.Forms.RadioButton();
            this.validButton = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Label();
            this.rbChoix1 = new System.Windows.Forms.RadioButton();
            this.rbChoix2 = new System.Windows.Forms.RadioButton();
            this.rbChoix3 = new System.Windows.Forms.RadioButton();
            this.groupBoxRb = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.verifLB = new System.Windows.Forms.Label();
            this.timerAfficheResultat = new System.Windows.Forms.Timer(this.components);
            this.groupBoxRb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConsigne
            // 
            this.labelConsigne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConsigne.AutoSize = true;
            this.labelConsigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelConsigne.Location = new System.Drawing.Point(264, 41);
            this.labelConsigne.MaximumSize = new System.Drawing.Size(0, 530);
            this.labelConsigne.Name = "labelConsigne";
            this.labelConsigne.Size = new System.Drawing.Size(128, 29);
            this.labelConsigne.TabIndex = 0;
            this.labelConsigne.Text = "Consignes";
            // 
            // rbChoix4
            // 
            this.rbChoix4.AutoSize = true;
            this.rbChoix4.Location = new System.Drawing.Point(405, 12);
            this.rbChoix4.Name = "rbChoix4";
            this.rbChoix4.Size = new System.Drawing.Size(110, 21);
            this.rbChoix4.TabIndex = 5;
            this.rbChoix4.TabStop = true;
            this.rbChoix4.Text = "radioButton4";
            this.rbChoix4.UseVisualStyleBackColor = true;
            this.rbChoix4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.choixReponse_KeyDown);
            // 
            // validButton
            // 
            this.validButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.validButton.Location = new System.Drawing.Point(275, 403);
            this.validButton.Name = "validButton";
            this.validButton.Size = new System.Drawing.Size(106, 44);
            this.validButton.TabIndex = 6;
            this.validButton.Text = "Valider";
            this.validButton.UseVisualStyleBackColor = true;
            this.validButton.Click += new System.EventHandler(this.validButton_Click);
            // 
            // count
            // 
            this.count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(577, 475);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(67, 17);
            this.count.TabIndex = 8;
            this.count.Text = "compteur";
            // 
            // rbChoix1
            // 
            this.rbChoix1.AutoSize = true;
            this.rbChoix1.Location = new System.Drawing.Point(19, 12);
            this.rbChoix1.Name = "rbChoix1";
            this.rbChoix1.Size = new System.Drawing.Size(69, 21);
            this.rbChoix1.TabIndex = 2;
            this.rbChoix1.TabStop = true;
            this.rbChoix1.Text = "choix1";
            this.rbChoix1.UseVisualStyleBackColor = true;
            this.rbChoix1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.choixReponse_KeyDown);
            // 
            // rbChoix2
            // 
            this.rbChoix2.AutoSize = true;
            this.rbChoix2.Location = new System.Drawing.Point(160, 12);
            this.rbChoix2.Name = "rbChoix2";
            this.rbChoix2.Size = new System.Drawing.Size(110, 21);
            this.rbChoix2.TabIndex = 3;
            this.rbChoix2.TabStop = true;
            this.rbChoix2.Text = "radioButton2";
            this.rbChoix2.UseVisualStyleBackColor = true;
            this.rbChoix2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.choixReponse_KeyDown);
            // 
            // rbChoix3
            // 
            this.rbChoix3.AutoSize = true;
            this.rbChoix3.Location = new System.Drawing.Point(289, 12);
            this.rbChoix3.Name = "rbChoix3";
            this.rbChoix3.Size = new System.Drawing.Size(110, 21);
            this.rbChoix3.TabIndex = 4;
            this.rbChoix3.TabStop = true;
            this.rbChoix3.Text = "radioButton3";
            this.rbChoix3.UseVisualStyleBackColor = true;
            this.rbChoix3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.choixReponse_KeyDown);
            // 
            // groupBoxRb
            // 
            this.groupBoxRb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxRb.Controls.Add(this.rbChoix3);
            this.groupBoxRb.Controls.Add(this.rbChoix2);
            this.groupBoxRb.Controls.Add(this.rbChoix1);
            this.groupBoxRb.Controls.Add(this.rbChoix4);
            this.groupBoxRb.Location = new System.Drawing.Point(47, 342);
            this.groupBoxRb.Name = "groupBoxRb";
            this.groupBoxRb.Size = new System.Drawing.Size(549, 48);
            this.groupBoxRb.TabIndex = 7;
            this.groupBoxRb.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Location = new System.Drawing.Point(144, 97);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(369, 239);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // verifLB
            // 
            this.verifLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.verifLB.AutoSize = true;
            this.verifLB.Location = new System.Drawing.Point(141, 456);
            this.verifLB.Name = "verifLB";
            this.verifLB.Size = new System.Drawing.Size(35, 17);
            this.verifLB.TabIndex = 9;
            this.verifLB.Text = "verif";
            // 
            // timerAfficheResultat
            // 
            this.timerAfficheResultat.Tick += new System.EventHandler(this.timerAfficheResultat_Tick);
            // 
            // FormProbleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 501);
            this.Controls.Add(this.verifLB);
            this.Controls.Add(this.count);
            this.Controls.Add(this.groupBoxRb);
            this.Controls.Add(this.validButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelConsigne);
            this.Name = "FormProbleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Problemes";
            this.groupBoxRb.ResumeLayout(false);
            this.groupBoxRb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConsigne;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RadioButton rbChoix4;
        private System.Windows.Forms.Button validButton;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.RadioButton rbChoix1;
        private System.Windows.Forms.RadioButton rbChoix2;
        private System.Windows.Forms.RadioButton rbChoix3;
        private System.Windows.Forms.GroupBox groupBoxRb;
        private System.Windows.Forms.Label verifLB;
        private System.Windows.Forms.Timer timerAfficheResultat;
    }
}