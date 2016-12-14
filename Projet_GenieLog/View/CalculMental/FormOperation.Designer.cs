namespace Projet_GenieLog.View.CalculMental
{
    partial class FormOperation
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
            this.labelSigne = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chiffre1 = new System.Windows.Forms.Label();
            this.chiffre2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saisieResultat = new System.Windows.Forms.TextBox();
            this.validButton = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Label();
            this.timerDifficile = new System.Windows.Forms.Timer(this.components);
            this.timerAfficheResultat = new System.Windows.Forms.Timer(this.components);
            this.verifLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSigne
            // 
            this.labelSigne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSigne.AutoSize = true;
            this.labelSigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSigne.Location = new System.Drawing.Point(224, 99);
            this.labelSigne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSigne.Name = "labelSigne";
            this.labelSigne.Size = new System.Drawing.Size(48, 55);
            this.labelSigne.TabIndex = 0;
            this.labelSigne.Text = "s";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(184, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Résoudre";
            // 
            // chiffre1
            // 
            this.chiffre1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chiffre1.AutoSize = true;
            this.chiffre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.chiffre1.Location = new System.Drawing.Point(0, 99);
            this.chiffre1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chiffre1.Name = "chiffre1";
            this.chiffre1.Size = new System.Drawing.Size(205, 63);
            this.chiffre1.TabIndex = 2;
            this.chiffre1.Text = "chiffre1";
            this.chiffre1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chiffre2
            // 
            this.chiffre2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chiffre2.AutoSize = true;
            this.chiffre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.chiffre2.Location = new System.Drawing.Point(379, 99);
            this.chiffre2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chiffre2.Name = "chiffre2";
            this.chiffre2.Size = new System.Drawing.Size(114, 63);
            this.chiffre2.TabIndex = 3;
            this.chiffre2.Text = "ch2";
            this.chiffre2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "=";
            // 
            // saisieResultat
            // 
            this.saisieResultat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saisieResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.saisieResultat.Location = new System.Drawing.Point(140, 227);
            this.saisieResultat.Margin = new System.Windows.Forms.Padding(2);
            this.saisieResultat.Name = "saisieResultat";
            this.saisieResultat.Size = new System.Drawing.Size(213, 38);
            this.saisieResultat.TabIndex = 5;
            this.saisieResultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saisieResultat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.saisieResultat_KeyDown);
            // 
            // validButton
            // 
            this.validButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.validButton.Location = new System.Drawing.Point(206, 284);
            this.validButton.Margin = new System.Windows.Forms.Padding(2);
            this.validButton.Name = "validButton";
            this.validButton.Size = new System.Drawing.Size(80, 36);
            this.validButton.TabIndex = 6;
            this.validButton.Text = "Valider";
            this.validButton.UseVisualStyleBackColor = true;
            this.validButton.Click += new System.EventHandler(this.validButton_Click);
            // 
            // count
            // 
            this.count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(433, 386);
            this.count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(51, 13);
            this.count.TabIndex = 7;
            this.count.Text = "compteur";
            // 
            // timerDifficile
            // 
            this.timerDifficile.Tick += new System.EventHandler(this.timerDifficile_Tick);
            // 
            // timerAfficheResultat
            // 
            this.timerAfficheResultat.Tick += new System.EventHandler(this.timerAfficheResultat_Tick);
            // 
            // verifLB
            // 
            this.verifLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.verifLB.AutoSize = true;
            this.verifLB.Location = new System.Drawing.Point(233, 353);
            this.verifLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.verifLB.Name = "verifLB";
            this.verifLB.Size = new System.Drawing.Size(27, 13);
            this.verifLB.TabIndex = 8;
            this.verifLB.Text = "verif";
            // 
            // FormOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 407);
            this.Controls.Add(this.verifLB);
            this.Controls.Add(this.count);
            this.Controls.Add(this.validButton);
            this.Controls.Add(this.saisieResultat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chiffre2);
            this.Controls.Add(this.chiffre1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSigne);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSigne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chiffre1;
        private System.Windows.Forms.Label chiffre2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox saisieResultat;
        private System.Windows.Forms.Button validButton;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Timer timerDifficile;
        private System.Windows.Forms.Timer timerAfficheResultat;
        private System.Windows.Forms.Label verifLB;
    }
}