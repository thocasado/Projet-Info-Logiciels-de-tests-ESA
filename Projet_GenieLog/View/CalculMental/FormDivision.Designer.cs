﻿namespace Projet_GenieLog.View.CalculMental
{
    partial class FormDivision
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
            this.validButton = new System.Windows.Forms.Button();
            this.saisieResultat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chiffre2 = new System.Windows.Forms.Label();
            this.chiffre1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // validButton
            // 
            this.validButton.Location = new System.Drawing.Point(259, 410);
            this.validButton.Name = "validButton";
            this.validButton.Size = new System.Drawing.Size(75, 23);
            this.validButton.TabIndex = 27;
            this.validButton.Text = "Valider";
            this.validButton.UseVisualStyleBackColor = true;
            this.validButton.Click += new System.EventHandler(this.validButton_Click);
            // 
            // saisieResultat
            // 
            this.saisieResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.saisieResultat.Location = new System.Drawing.Point(162, 328);
            this.saisieResultat.Name = "saisieResultat";
            this.saisieResultat.Size = new System.Drawing.Size(283, 45);
            this.saisieResultat.TabIndex = 26;
            this.saisieResultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 69);
            this.label3.TabIndex = 25;
            this.label3.Text = "=";
            // 
            // chiffre2
            // 
            this.chiffre2.AutoSize = true;
            this.chiffre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.chiffre2.Location = new System.Drawing.Point(397, 147);
            this.chiffre2.Name = "chiffre2";
            this.chiffre2.Size = new System.Drawing.Size(252, 76);
            this.chiffre2.TabIndex = 24;
            this.chiffre2.Text = "chiffre2";
            // 
            // chiffre1
            // 
            this.chiffre1.AutoSize = true;
            this.chiffre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.chiffre1.Location = new System.Drawing.Point(11, 147);
            this.chiffre1.Name = "chiffre1";
            this.chiffre1.Size = new System.Drawing.Size(252, 76);
            this.chiffre1.TabIndex = 23;
            this.chiffre1.Text = "chiffre1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(221, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 39);
            this.label2.TabIndex = 22;
            this.label2.Text = "Résoudre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 69);
            this.label1.TabIndex = 21;
            this.label1.Text = "/";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(564, 447);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(67, 17);
            this.count.TabIndex = 28;
            this.count.Text = "compteur";
            // 
            // FormDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 497);
            this.Controls.Add(this.count);
            this.Controls.Add(this.validButton);
            this.Controls.Add(this.saisieResultat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chiffre2);
            this.Controls.Add(this.chiffre1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDivision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDivision";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button validButton;
        private System.Windows.Forms.TextBox saisieResultat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label chiffre2;
        private System.Windows.Forms.Label chiffre1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label count;
    }
}