namespace Projet_GenieLog
{
    partial class MainMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPerception = new System.Windows.Forms.Button();
            this.btnConcentration = new System.Windows.Forms.Button();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.btn_maths = new System.Windows.Forms.Button();
            this.btn_physique = new System.Windows.Forms.Button();
            this.radio_facile = new System.Windows.Forms.RadioButton();
            this.radio_difficile = new System.Windows.Forms.RadioButton();
            this.label_difficulte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPerception
            // 
            this.btnPerception.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPerception.Location = new System.Drawing.Point(173, 77);
            this.btnPerception.Name = "btnPerception";
            this.btnPerception.Size = new System.Drawing.Size(134, 41);
            this.btnPerception.TabIndex = 0;
            this.btnPerception.Text = "Perception";
            this.btnPerception.UseVisualStyleBackColor = true;
            this.btnPerception.Click += new System.EventHandler(this.btnPerception_Click);
            // 
            // btnConcentration
            // 
            this.btnConcentration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConcentration.Location = new System.Drawing.Point(173, 124);
            this.btnConcentration.Name = "btnConcentration";
            this.btnConcentration.Size = new System.Drawing.Size(134, 41);
            this.btnConcentration.TabIndex = 1;
            this.btnConcentration.Text = "Concentration";
            this.btnConcentration.UseVisualStyleBackColor = true;
            // 
            // btnCalcul
            // 
            this.btnCalcul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalcul.Location = new System.Drawing.Point(173, 171);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(134, 41);
            this.btnCalcul.TabIndex = 2;
            this.btnCalcul.Text = "Calcul Mental";
            this.btnCalcul.UseVisualStyleBackColor = true;
            // 
            // btn_maths
            // 
            this.btn_maths.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_maths.Location = new System.Drawing.Point(173, 218);
            this.btn_maths.Name = "btn_maths";
            this.btn_maths.Size = new System.Drawing.Size(134, 41);
            this.btn_maths.TabIndex = 3;
            this.btn_maths.Text = "Mathématiques";
            this.btn_maths.UseVisualStyleBackColor = true;
            // 
            // btn_physique
            // 
            this.btn_physique.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_physique.Location = new System.Drawing.Point(173, 265);
            this.btn_physique.Name = "btn_physique";
            this.btn_physique.Size = new System.Drawing.Size(134, 41);
            this.btn_physique.TabIndex = 4;
            this.btn_physique.Text = "Physique";
            this.btn_physique.UseVisualStyleBackColor = true;
            // 
            // radio_facile
            // 
            this.radio_facile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radio_facile.AutoSize = true;
            this.radio_facile.Checked = true;
            this.radio_facile.Location = new System.Drawing.Point(173, 349);
            this.radio_facile.Name = "radio_facile";
            this.radio_facile.Size = new System.Drawing.Size(53, 17);
            this.radio_facile.TabIndex = 5;
            this.radio_facile.TabStop = true;
            this.radio_facile.Text = "Facile";
            this.radio_facile.UseVisualStyleBackColor = true;
            // 
            // radio_difficile
            // 
            this.radio_difficile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radio_difficile.AutoSize = true;
            this.radio_difficile.Location = new System.Drawing.Point(250, 349);
            this.radio_difficile.Name = "radio_difficile";
            this.radio_difficile.Size = new System.Drawing.Size(57, 17);
            this.radio_difficile.TabIndex = 6;
            this.radio_difficile.Text = "Dfficile";
            this.radio_difficile.UseVisualStyleBackColor = true;
            // 
            // label_difficulte
            // 
            this.label_difficulte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_difficulte.AutoSize = true;
            this.label_difficulte.Location = new System.Drawing.Point(218, 330);
            this.label_difficulte.Name = "label_difficulte";
            this.label_difficulte.Size = new System.Drawing.Size(48, 13);
            this.label_difficulte.TabIndex = 7;
            this.label_difficulte.Text = "Difficulté";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 407);
            this.Controls.Add(this.label_difficulte);
            this.Controls.Add(this.radio_difficile);
            this.Controls.Add(this.radio_facile);
            this.Controls.Add(this.btn_physique);
            this.Controls.Add(this.btn_maths);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.btnConcentration);
            this.Controls.Add(this.btnPerception);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPerception;
        private System.Windows.Forms.Button btnConcentration;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.Button btn_maths;
        private System.Windows.Forms.Button btn_physique;
        private System.Windows.Forms.RadioButton radio_facile;
        private System.Windows.Forms.RadioButton radio_difficile;
        private System.Windows.Forms.Label label_difficulte;
    }
}

