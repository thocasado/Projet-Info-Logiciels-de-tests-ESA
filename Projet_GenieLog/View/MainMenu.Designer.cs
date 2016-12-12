﻿namespace Projet_GenieLog
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
            this.components = new System.ComponentModel.Container();
            this.btnPerception = new System.Windows.Forms.Button();
            this.btnConcentration = new System.Windows.Forms.Button();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.btn_maths = new System.Windows.Forms.Button();
            this.btn_physique = new System.Windows.Forms.Button();
            this.radio_facile = new System.Windows.Forms.RadioButton();
            this.radio_difficile = new System.Windows.Forms.RadioButton();
            this.label_difficulte = new System.Windows.Forms.Label();
            this.groupBoxDifficulte = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomUtilisateurTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rPerceptionLB = new System.Windows.Forms.Label();
            this.rConcentrationLB = new System.Windows.Forms.Label();
            this.rCmLB = new System.Windows.Forms.Label();
            this.rMathsLB = new System.Windows.Forms.Label();
            this.rPhysiqueLB = new System.Windows.Forms.Label();
            this.RaffraichissementMenuTimer = new System.Windows.Forms.Timer(this.components);
            this.timerRentrerNom = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxAccueil = new System.Windows.Forms.PictureBox();
            this.pictureBoxChecked = new System.Windows.Forms.PictureBox();
            this.timerChargementMenu = new System.Windows.Forms.Timer(this.components);
            this.groupBoxDifficulte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccueil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChecked)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPerception
            // 
            this.btnPerception.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPerception.Location = new System.Drawing.Point(231, 95);
            this.btnPerception.Margin = new System.Windows.Forms.Padding(4);
            this.btnPerception.Name = "btnPerception";
            this.btnPerception.Size = new System.Drawing.Size(179, 50);
            this.btnPerception.TabIndex = 0;
            this.btnPerception.Text = "Perception";
            this.btnPerception.UseVisualStyleBackColor = true;
            this.btnPerception.Click += new System.EventHandler(this.btnPerception_Click);
            // 
            // btnConcentration
            // 
            this.btnConcentration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConcentration.Location = new System.Drawing.Point(231, 153);
            this.btnConcentration.Margin = new System.Windows.Forms.Padding(4);
            this.btnConcentration.Name = "btnConcentration";
            this.btnConcentration.Size = new System.Drawing.Size(179, 50);
            this.btnConcentration.TabIndex = 1;
            this.btnConcentration.Text = "Concentration";
            this.btnConcentration.UseVisualStyleBackColor = true;
            this.btnConcentration.Click += new System.EventHandler(this.btnConcentration_Click);
            // 
            // btnCalcul
            // 
            this.btnCalcul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalcul.Location = new System.Drawing.Point(231, 210);
            this.btnCalcul.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(179, 50);
            this.btnCalcul.TabIndex = 2;
            this.btnCalcul.Text = "Calcul Mental";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // btn_maths
            // 
            this.btn_maths.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_maths.Location = new System.Drawing.Point(231, 268);
            this.btn_maths.Margin = new System.Windows.Forms.Padding(4);
            this.btn_maths.Name = "btn_maths";
            this.btn_maths.Size = new System.Drawing.Size(179, 50);
            this.btn_maths.TabIndex = 3;
            this.btn_maths.Text = "Mathématiques";
            this.btn_maths.UseVisualStyleBackColor = true;
            this.btn_maths.Click += new System.EventHandler(this.btn_maths_Click);
            // 
            // btn_physique
            // 
            this.btn_physique.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_physique.Location = new System.Drawing.Point(231, 326);
            this.btn_physique.Margin = new System.Windows.Forms.Padding(4);
            this.btn_physique.Name = "btn_physique";
            this.btn_physique.Size = new System.Drawing.Size(179, 50);
            this.btn_physique.TabIndex = 4;
            this.btn_physique.Text = "Physique";
            this.btn_physique.UseVisualStyleBackColor = true;
            this.btn_physique.Click += new System.EventHandler(this.btn_maths_Click);
            // 
            // radio_facile
            // 
            this.radio_facile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radio_facile.AutoSize = true;
            this.radio_facile.Checked = true;
            this.radio_facile.Location = new System.Drawing.Point(45, 20);
            this.radio_facile.Margin = new System.Windows.Forms.Padding(4);
            this.radio_facile.Name = "radio_facile";
            this.radio_facile.Size = new System.Drawing.Size(66, 21);
            this.radio_facile.TabIndex = 5;
            this.radio_facile.TabStop = true;
            this.radio_facile.Text = "Facile";
            this.radio_facile.UseVisualStyleBackColor = true;
            // 
            // radio_difficile
            // 
            this.radio_difficile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radio_difficile.AutoSize = true;
            this.radio_difficile.Location = new System.Drawing.Point(147, 20);
            this.radio_difficile.Margin = new System.Windows.Forms.Padding(4);
            this.radio_difficile.Name = "radio_difficile";
            this.radio_difficile.Size = new System.Drawing.Size(71, 21);
            this.radio_difficile.TabIndex = 6;
            this.radio_difficile.Text = "Dfficile";
            this.radio_difficile.UseVisualStyleBackColor = true;
            this.radio_difficile.CheckedChanged += new System.EventHandler(this.radio_difficile_CheckedChanged);
            // 
            // label_difficulte
            // 
            this.label_difficulte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_difficulte.AutoSize = true;
            this.label_difficulte.Location = new System.Drawing.Point(291, 406);
            this.label_difficulte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_difficulte.Name = "label_difficulte";
            this.label_difficulte.Size = new System.Drawing.Size(62, 17);
            this.label_difficulte.TabIndex = 7;
            this.label_difficulte.Text = "Difficulté";
            // 
            // groupBoxDifficulte
            // 
            this.groupBoxDifficulte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDifficulte.Controls.Add(this.radio_facile);
            this.groupBoxDifficulte.Controls.Add(this.radio_difficile);
            this.groupBoxDifficulte.Location = new System.Drawing.Point(207, 426);
            this.groupBoxDifficulte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDifficulte.Name = "groupBoxDifficulte";
            this.groupBoxDifficulte.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDifficulte.Size = new System.Drawing.Size(235, 47);
            this.groupBoxDifficulte.TabIndex = 8;
            this.groupBoxDifficulte.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom utilisateur testé";
            // 
            // nomUtilisateurTB
            // 
            this.nomUtilisateurTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomUtilisateurTB.Location = new System.Drawing.Point(245, 38);
            this.nomUtilisateurTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomUtilisateurTB.Name = "nomUtilisateurTB";
            this.nomUtilisateurTB.Size = new System.Drawing.Size(137, 22);
            this.nomUtilisateurTB.TabIndex = 10;
            this.nomUtilisateurTB.TextChanged += new System.EventHandler(this.nomUtilisateurTB_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Résultat actuel";
            // 
            // rPerceptionLB
            // 
            this.rPerceptionLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rPerceptionLB.AutoSize = true;
            this.rPerceptionLB.Location = new System.Drawing.Point(512, 112);
            this.rPerceptionLB.Name = "rPerceptionLB";
            this.rPerceptionLB.Size = new System.Drawing.Size(32, 17);
            this.rPerceptionLB.TabIndex = 13;
            this.rPerceptionLB.Text = "...%";
            // 
            // rConcentrationLB
            // 
            this.rConcentrationLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rConcentrationLB.AutoSize = true;
            this.rConcentrationLB.Location = new System.Drawing.Point(512, 170);
            this.rConcentrationLB.Name = "rConcentrationLB";
            this.rConcentrationLB.Size = new System.Drawing.Size(32, 17);
            this.rConcentrationLB.TabIndex = 14;
            this.rConcentrationLB.Text = "...%";
            // 
            // rCmLB
            // 
            this.rCmLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rCmLB.AutoSize = true;
            this.rCmLB.Location = new System.Drawing.Point(512, 226);
            this.rCmLB.Name = "rCmLB";
            this.rCmLB.Size = new System.Drawing.Size(32, 17);
            this.rCmLB.TabIndex = 15;
            this.rCmLB.Text = "...%";
            // 
            // rMathsLB
            // 
            this.rMathsLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rMathsLB.AutoSize = true;
            this.rMathsLB.Location = new System.Drawing.Point(512, 286);
            this.rMathsLB.Name = "rMathsLB";
            this.rMathsLB.Size = new System.Drawing.Size(32, 17);
            this.rMathsLB.TabIndex = 16;
            this.rMathsLB.Text = "...%";
            // 
            // rPhysiqueLB
            // 
            this.rPhysiqueLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rPhysiqueLB.AutoSize = true;
            this.rPhysiqueLB.Location = new System.Drawing.Point(512, 343);
            this.rPhysiqueLB.Name = "rPhysiqueLB";
            this.rPhysiqueLB.Size = new System.Drawing.Size(32, 17);
            this.rPhysiqueLB.TabIndex = 17;
            this.rPhysiqueLB.Text = "...%";
            // 
            // RaffraichissementMenuTimer
            // 
            this.RaffraichissementMenuTimer.Interval = 1000;
            this.RaffraichissementMenuTimer.Tick += new System.EventHandler(this.RaffraichissementMenuTimer_Tick);
            // 
            // timerRentrerNom
            // 
            this.timerRentrerNom.Interval = 10000;
            this.timerRentrerNom.Tick += new System.EventHandler(this.timerRentrerNom_Tick);
            // 
            // pictureBoxAccueil
            // 
            this.pictureBoxAccueil.Image = global::Projet_GenieLog.Properties.Resources.loadingPage;
            this.pictureBoxAccueil.Location = new System.Drawing.Point(-2, 0);
            this.pictureBoxAccueil.Name = "pictureBoxAccueil";
            this.pictureBoxAccueil.Size = new System.Drawing.Size(659, 502);
            this.pictureBoxAccueil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAccueil.TabIndex = 19;
            this.pictureBoxAccueil.TabStop = false;
            this.pictureBoxAccueil.UseWaitCursor = true;
            // 
            // pictureBoxChecked
            // 
            this.pictureBoxChecked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxChecked.Image = global::Projet_GenieLog.Properties.Resources._checked;
            this.pictureBoxChecked.InitialImage = global::Projet_GenieLog.Properties.Resources._checked;
            this.pictureBoxChecked.Location = new System.Drawing.Point(389, 33);
            this.pictureBoxChecked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxChecked.Name = "pictureBoxChecked";
            this.pictureBoxChecked.Size = new System.Drawing.Size(31, 27);
            this.pictureBoxChecked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChecked.TabIndex = 11;
            this.pictureBoxChecked.TabStop = false;
            this.pictureBoxChecked.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerChargementMenu
            // 
            this.timerChargementMenu.Tick += new System.EventHandler(this.timerChargementMenu_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 501);
            this.Controls.Add(this.pictureBoxAccueil);
            this.Controls.Add(this.rPhysiqueLB);
            this.Controls.Add(this.rMathsLB);
            this.Controls.Add(this.rCmLB);
            this.Controls.Add(this.rConcentrationLB);
            this.Controls.Add(this.rPerceptionLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxChecked);
            this.Controls.Add(this.nomUtilisateurTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxDifficulte);
            this.Controls.Add(this.label_difficulte);
            this.Controls.Add(this.btn_physique);
            this.Controls.Add(this.btn_maths);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.btnConcentration);
            this.Controls.Add(this.btnPerception);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.groupBoxDifficulte.ResumeLayout(false);
            this.groupBoxDifficulte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccueil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChecked)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxDifficulte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomUtilisateurTB;
        private System.Windows.Forms.PictureBox pictureBoxChecked;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label rPerceptionLB;
        public System.Windows.Forms.Label rConcentrationLB;
        public System.Windows.Forms.Label rCmLB;
        public System.Windows.Forms.Label rMathsLB;
        public System.Windows.Forms.Label rPhysiqueLB;
        private System.Windows.Forms.Timer RaffraichissementMenuTimer;
        private System.Windows.Forms.Timer timerRentrerNom;
        private System.Windows.Forms.PictureBox pictureBoxAccueil;
        private System.Windows.Forms.Timer timerChargementMenu;
    }
}

