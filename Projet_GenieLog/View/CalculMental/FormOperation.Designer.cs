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
            this.SuspendLayout();
            // 
            // labelSigne
            // 
            this.labelSigne.AutoSize = true;
            this.labelSigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSigne.Location = new System.Drawing.Point(283, 185);
            this.labelSigne.Name = "labelSigne";
            this.labelSigne.Size = new System.Drawing.Size(60, 69);
            this.labelSigne.TabIndex = 0;
            this.labelSigne.Text = "s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(235, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Résoudre";
            // 
            // chiffre1
            // 
            this.chiffre1.AutoSize = true;
            this.chiffre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.chiffre1.Location = new System.Drawing.Point(15, 179);
            this.chiffre1.Name = "chiffre1";
            this.chiffre1.Size = new System.Drawing.Size(252, 76);
            this.chiffre1.TabIndex = 2;
            this.chiffre1.Text = "chiffre1";
            // 
            // chiffre2
            // 
            this.chiffre2.AutoSize = true;
            this.chiffre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.chiffre2.Location = new System.Drawing.Point(382, 179);
            this.chiffre2.Name = "chiffre2";
            this.chiffre2.Size = new System.Drawing.Size(252, 76);
            this.chiffre2.TabIndex = 3;
            this.chiffre2.Text = "chiffre2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 69);
            this.label3.TabIndex = 4;
            this.label3.Text = "=";
            // 
            // saisieResultat
            // 
            this.saisieResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.saisieResultat.Location = new System.Drawing.Point(176, 359);
            this.saisieResultat.Name = "saisieResultat";
            this.saisieResultat.Size = new System.Drawing.Size(283, 45);
            this.saisieResultat.TabIndex = 5;
            this.saisieResultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // validButton
            // 
            this.validButton.Location = new System.Drawing.Point(273, 441);
            this.validButton.Name = "validButton";
            this.validButton.Size = new System.Drawing.Size(75, 23);
            this.validButton.TabIndex = 6;
            this.validButton.Text = "Valider";
            this.validButton.UseVisualStyleBackColor = true;
            this.validButton.Click += new System.EventHandler(this.validButton_Click);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(571, 432);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(67, 17);
            this.count.TabIndex = 7;
            this.count.Text = "compteur";
            // 
            // timerDifficile
            // 
            this.timerDifficile.Tick += new System.EventHandler(this.timerDifficile_Tick);
            // 
            // FormAddition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 501);
            this.Controls.Add(this.count);
            this.Controls.Add(this.validButton);
            this.Controls.Add(this.saisieResultat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chiffre2);
            this.Controls.Add(this.chiffre1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSigne);
            this.Name = "FormAddition";
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
    }
}