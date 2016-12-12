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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rPerceptionLB = new System.Windows.Forms.Label();
            this.rConcentrationLB = new System.Windows.Forms.Label();
            this.rCmLB = new System.Windows.Forms.Label();
            this.rMathsLB = new System.Windows.Forms.Label();
            this.rPhysiqueLB = new System.Windows.Forms.Label();
            this.RaffraichissementMenuTimer = new System.Windows.Forms.Timer(this.components);
            this.timerRentrerNom = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBoxDifficulte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.btnConcentration.Click += new System.EventHandler(this.btnConcentration_Click);
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
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
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
            this.btn_maths.Click += new System.EventHandler(this.btn_maths_Click);
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
            this.btn_physique.Click += new System.EventHandler(this.btn_maths_Click);
            // 
            // radio_facile
            // 
            this.radio_facile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radio_facile.AutoSize = true;
            this.radio_facile.Checked = true;
            this.radio_facile.Location = new System.Drawing.Point(34, 16);
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
            this.radio_difficile.Location = new System.Drawing.Point(110, 16);
            this.radio_difficile.Name = "radio_difficile";
            this.radio_difficile.Size = new System.Drawing.Size(57, 17);
            this.radio_difficile.TabIndex = 6;
            this.radio_difficile.Text = "Dfficile";
            this.radio_difficile.UseVisualStyleBackColor = true;
            this.radio_difficile.CheckedChanged += new System.EventHandler(this.radio_difficile_CheckedChanged);
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
            // groupBoxDifficulte
            // 
            this.groupBoxDifficulte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDifficulte.Controls.Add(this.radio_facile);
            this.groupBoxDifficulte.Controls.Add(this.radio_difficile);
            this.groupBoxDifficulte.Location = new System.Drawing.Point(155, 346);
            this.groupBoxDifficulte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDifficulte.Name = "groupBoxDifficulte";
            this.groupBoxDifficulte.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDifficulte.Size = new System.Drawing.Size(176, 38);
            this.groupBoxDifficulte.TabIndex = 8;
            this.groupBoxDifficulte.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom utilisateur testé";
            // 
            // nomUtilisateurTB
            // 
            this.nomUtilisateurTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomUtilisateurTB.Location = new System.Drawing.Point(184, 31);
            this.nomUtilisateurTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomUtilisateurTB.Name = "nomUtilisateurTB";
            this.nomUtilisateurTB.Size = new System.Drawing.Size(104, 20);
            this.nomUtilisateurTB.TabIndex = 10;
            this.nomUtilisateurTB.TextChanged += new System.EventHandler(this.nomUtilisateurTB_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Projet_GenieLog.Properties.Resources._checked;
            this.pictureBox1.InitialImage = global::Projet_GenieLog.Properties.Resources._checked;
            this.pictureBox1.Location = new System.Drawing.Point(292, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Résultat actuel";
            // 
            // rPerceptionLB
            // 
            this.rPerceptionLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rPerceptionLB.AutoSize = true;
            this.rPerceptionLB.Location = new System.Drawing.Point(384, 91);
            this.rPerceptionLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rPerceptionLB.Name = "rPerceptionLB";
            this.rPerceptionLB.Size = new System.Drawing.Size(24, 13);
            this.rPerceptionLB.TabIndex = 13;
            this.rPerceptionLB.Text = "...%";
            // 
            // rConcentrationLB
            // 
            this.rConcentrationLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rConcentrationLB.AutoSize = true;
            this.rConcentrationLB.Location = new System.Drawing.Point(384, 138);
            this.rConcentrationLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rConcentrationLB.Name = "rConcentrationLB";
            this.rConcentrationLB.Size = new System.Drawing.Size(24, 13);
            this.rConcentrationLB.TabIndex = 14;
            this.rConcentrationLB.Text = "...%";
            // 
            // rCmLB
            // 
            this.rCmLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rCmLB.AutoSize = true;
            this.rCmLB.Location = new System.Drawing.Point(384, 184);
            this.rCmLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rCmLB.Name = "rCmLB";
            this.rCmLB.Size = new System.Drawing.Size(24, 13);
            this.rCmLB.TabIndex = 15;
            this.rCmLB.Text = "...%";
            // 
            // rMathsLB
            // 
            this.rMathsLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rMathsLB.AutoSize = true;
            this.rMathsLB.Location = new System.Drawing.Point(384, 232);
            this.rMathsLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rMathsLB.Name = "rMathsLB";
            this.rMathsLB.Size = new System.Drawing.Size(24, 13);
            this.rMathsLB.TabIndex = 16;
            this.rMathsLB.Text = "...%";
            // 
            // rPhysiqueLB
            // 
            this.rPhysiqueLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rPhysiqueLB.AutoSize = true;
            this.rPhysiqueLB.Location = new System.Drawing.Point(384, 279);
            this.rPhysiqueLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rPhysiqueLB.Name = "rPhysiqueLB";
            this.rPhysiqueLB.Size = new System.Drawing.Size(24, 13);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 407);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rPhysiqueLB);
            this.Controls.Add(this.rMathsLB);
            this.Controls.Add(this.rCmLB);
            this.Controls.Add(this.rConcentrationLB);
            this.Controls.Add(this.rPerceptionLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nomUtilisateurTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxDifficulte);
            this.Controls.Add(this.label_difficulte);
            this.Controls.Add(this.btn_physique);
            this.Controls.Add(this.btn_maths);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.btnConcentration);
            this.Controls.Add(this.btnPerception);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.groupBoxDifficulte.ResumeLayout(false);
            this.groupBoxDifficulte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label rPerceptionLB;
        public System.Windows.Forms.Label rConcentrationLB;
        public System.Windows.Forms.Label rCmLB;
        public System.Windows.Forms.Label rMathsLB;
        public System.Windows.Forms.Label rPhysiqueLB;
        private System.Windows.Forms.Timer RaffraichissementMenuTimer;
        private System.Windows.Forms.Timer timerRentrerNom;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

