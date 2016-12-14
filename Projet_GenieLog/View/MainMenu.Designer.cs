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
            this.btnPerception = new System.Windows.Forms.Button();
            this.btnConcentration = new System.Windows.Forms.Button();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.btnMaths = new System.Windows.Forms.Button();
            this.btnPhysique = new System.Windows.Forms.Button();
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
            this.pictureBoxChecked = new System.Windows.Forms.PictureBox();
            this.timerChargementMenu = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxAccueil = new System.Windows.Forms.PictureBox();
            this.groupBoxDifficulte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChecked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccueil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPerception
            // 
            this.btnPerception.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPerception.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnPerception.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPerception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerception.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnPerception.ForeColor = System.Drawing.Color.White;
            this.btnPerception.Location = new System.Drawing.Point(176, 77);
            this.btnPerception.Name = "btnPerception";
            this.btnPerception.Size = new System.Drawing.Size(134, 41);
            this.btnPerception.TabIndex = 0;
            this.btnPerception.Text = "Perception";
            this.btnPerception.UseVisualStyleBackColor = false;
            this.btnPerception.Click += new System.EventHandler(this.loadTest);
            // 
            // btnConcentration
            // 
            this.btnConcentration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConcentration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnConcentration.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConcentration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcentration.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnConcentration.ForeColor = System.Drawing.Color.White;
            this.btnConcentration.Location = new System.Drawing.Point(176, 124);
            this.btnConcentration.Name = "btnConcentration";
            this.btnConcentration.Size = new System.Drawing.Size(134, 41);
            this.btnConcentration.TabIndex = 1;
            this.btnConcentration.Text = "Concentration";
            this.btnConcentration.UseVisualStyleBackColor = false;
            this.btnConcentration.Click += new System.EventHandler(this.loadTest);
            // 
            // btnCalcul
            // 
            this.btnCalcul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalcul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnCalcul.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCalcul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcul.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalcul.ForeColor = System.Drawing.Color.White;
            this.btnCalcul.Location = new System.Drawing.Point(176, 171);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(134, 41);
            this.btnCalcul.TabIndex = 2;
            this.btnCalcul.Text = "Calcul Mental";
            this.btnCalcul.UseVisualStyleBackColor = false;
            this.btnCalcul.Click += new System.EventHandler(this.loadTest);
            // 
            // btnMaths
            // 
            this.btnMaths.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnMaths.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMaths.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaths.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaths.ForeColor = System.Drawing.Color.White;
            this.btnMaths.Location = new System.Drawing.Point(176, 218);
            this.btnMaths.Name = "btnMaths";
            this.btnMaths.Size = new System.Drawing.Size(134, 41);
            this.btnMaths.TabIndex = 3;
            this.btnMaths.Text = "Mathématiques";
            this.btnMaths.UseVisualStyleBackColor = false;
            this.btnMaths.Click += new System.EventHandler(this.loadTest);
            // 
            // btnPhysique
            // 
            this.btnPhysique.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPhysique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnPhysique.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPhysique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhysique.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnPhysique.ForeColor = System.Drawing.Color.White;
            this.btnPhysique.Location = new System.Drawing.Point(176, 265);
            this.btnPhysique.Name = "btnPhysique";
            this.btnPhysique.Size = new System.Drawing.Size(134, 41);
            this.btnPhysique.TabIndex = 4;
            this.btnPhysique.Text = "Physique";
            this.btnPhysique.UseVisualStyleBackColor = false;
            this.btnPhysique.Click += new System.EventHandler(this.loadTest);
            // 
            // radio_facile
            // 
            this.radio_facile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radio_facile.AutoSize = true;
            this.radio_facile.Checked = true;
            this.radio_facile.Location = new System.Drawing.Point(5, 16);
            this.radio_facile.Name = "radio_facile";
            this.radio_facile.Size = new System.Drawing.Size(58, 21);
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
            this.radio_difficile.Size = new System.Drawing.Size(66, 21);
            this.radio_difficile.TabIndex = 6;
            this.radio_difficile.Text = "Dfficile";
            this.radio_difficile.UseVisualStyleBackColor = true;
            this.radio_difficile.CheckedChanged += new System.EventHandler(this.radio_difficile_CheckedChanged);
            // 
            // label_difficulte
            // 
            this.label_difficulte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_difficulte.AutoSize = true;
            this.label_difficulte.BackColor = System.Drawing.Color.Transparent;
            this.label_difficulte.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_difficulte.ForeColor = System.Drawing.Color.White;
            this.label_difficulte.Location = new System.Drawing.Point(221, 330);
            this.label_difficulte.Name = "label_difficulte";
            this.label_difficulte.Size = new System.Drawing.Size(61, 17);
            this.label_difficulte.TabIndex = 7;
            this.label_difficulte.Text = "Difficulté";
            // 
            // groupBoxDifficulte
            // 
            this.groupBoxDifficulte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDifficulte.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDifficulte.Controls.Add(this.radio_facile);
            this.groupBoxDifficulte.Controls.Add(this.radio_difficile);
            this.groupBoxDifficulte.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDifficulte.ForeColor = System.Drawing.Color.White;
            this.groupBoxDifficulte.Location = new System.Drawing.Point(158, 346);
            this.groupBoxDifficulte.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDifficulte.Name = "groupBoxDifficulte";
            this.groupBoxDifficulte.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDifficulte.Size = new System.Drawing.Size(176, 38);
            this.groupBoxDifficulte.TabIndex = 8;
            this.groupBoxDifficulte.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom utilisateur testé";
            // 
            // nomUtilisateurTB
            // 
            this.nomUtilisateurTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomUtilisateurTB.Location = new System.Drawing.Point(184, 31);
            this.nomUtilisateurTB.Margin = new System.Windows.Forms.Padding(2);
            this.nomUtilisateurTB.Name = "nomUtilisateurTB";
            this.nomUtilisateurTB.Size = new System.Drawing.Size(104, 20);
            this.nomUtilisateurTB.TabIndex = 10;
            this.nomUtilisateurTB.TextChanged += new System.EventHandler(this.nomUtilisateurTB_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(351, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Résultat actuel";
            // 
            // rPerceptionLB
            // 
            this.rPerceptionLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rPerceptionLB.AutoSize = true;
            this.rPerceptionLB.BackColor = System.Drawing.Color.Transparent;
            this.rPerceptionLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rPerceptionLB.ForeColor = System.Drawing.Color.White;
            this.rPerceptionLB.Location = new System.Drawing.Point(384, 91);
            this.rPerceptionLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rPerceptionLB.Name = "rPerceptionLB";
            this.rPerceptionLB.Size = new System.Drawing.Size(33, 19);
            this.rPerceptionLB.TabIndex = 13;
            this.rPerceptionLB.Text = "...%";
            // 
            // rConcentrationLB
            // 
            this.rConcentrationLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rConcentrationLB.AutoSize = true;
            this.rConcentrationLB.BackColor = System.Drawing.Color.Transparent;
            this.rConcentrationLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rConcentrationLB.ForeColor = System.Drawing.Color.White;
            this.rConcentrationLB.Location = new System.Drawing.Point(384, 138);
            this.rConcentrationLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rConcentrationLB.Name = "rConcentrationLB";
            this.rConcentrationLB.Size = new System.Drawing.Size(33, 19);
            this.rConcentrationLB.TabIndex = 14;
            this.rConcentrationLB.Text = "...%";
            // 
            // rCmLB
            // 
            this.rCmLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rCmLB.AutoSize = true;
            this.rCmLB.BackColor = System.Drawing.Color.Transparent;
            this.rCmLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rCmLB.ForeColor = System.Drawing.Color.White;
            this.rCmLB.Location = new System.Drawing.Point(384, 184);
            this.rCmLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rCmLB.Name = "rCmLB";
            this.rCmLB.Size = new System.Drawing.Size(33, 19);
            this.rCmLB.TabIndex = 15;
            this.rCmLB.Text = "...%";
            // 
            // rMathsLB
            // 
            this.rMathsLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rMathsLB.AutoSize = true;
            this.rMathsLB.BackColor = System.Drawing.Color.Transparent;
            this.rMathsLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rMathsLB.ForeColor = System.Drawing.Color.White;
            this.rMathsLB.Location = new System.Drawing.Point(384, 232);
            this.rMathsLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rMathsLB.Name = "rMathsLB";
            this.rMathsLB.Size = new System.Drawing.Size(33, 19);
            this.rMathsLB.TabIndex = 16;
            this.rMathsLB.Text = "...%";
            // 
            // rPhysiqueLB
            // 
            this.rPhysiqueLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rPhysiqueLB.AutoSize = true;
            this.rPhysiqueLB.BackColor = System.Drawing.Color.Transparent;
            this.rPhysiqueLB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rPhysiqueLB.ForeColor = System.Drawing.Color.White;
            this.rPhysiqueLB.Location = new System.Drawing.Point(384, 279);
            this.rPhysiqueLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rPhysiqueLB.Name = "rPhysiqueLB";
            this.rPhysiqueLB.Size = new System.Drawing.Size(33, 19);
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
            // pictureBoxChecked
            // 
            this.pictureBoxChecked.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxChecked.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChecked.Image = global::Projet_GenieLog.Properties.Resources.checked1;
            this.pictureBoxChecked.InitialImage = global::Projet_GenieLog.Properties.Resources._checked;
            this.pictureBoxChecked.Location = new System.Drawing.Point(292, 27);
            this.pictureBoxChecked.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxChecked.Name = "pictureBoxChecked";
            this.pictureBoxChecked.Size = new System.Drawing.Size(23, 22);
            this.pictureBoxChecked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChecked.TabIndex = 11;
            this.pictureBoxChecked.TabStop = false;
            this.pictureBoxChecked.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerChargementMenu
            // 
            this.timerChargementMenu.Tick += new System.EventHandler(this.timerChargementMenu_Tick);
            // 
            // pictureBoxAccueil
            // 
            this.pictureBoxAccueil.Image = global::Projet_GenieLog.Properties.Resources.loadingPage;
            this.pictureBoxAccueil.Location = new System.Drawing.Point(-2, -3);
            this.pictureBoxAccueil.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAccueil.Name = "pictureBoxAccueil";
            this.pictureBoxAccueil.Size = new System.Drawing.Size(498, 410);
            this.pictureBoxAccueil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAccueil.TabIndex = 20;
            this.pictureBoxAccueil.TabStop = false;
            this.pictureBoxAccueil.UseWaitCursor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 407);
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
            this.Controls.Add(this.btnPhysique);
            this.Controls.Add(this.btnMaths);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.btnConcentration);
            this.Controls.Add(this.btnPerception);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.groupBoxDifficulte.ResumeLayout(false);
            this.groupBoxDifficulte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChecked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccueil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPerception;
        private System.Windows.Forms.Button btnConcentration;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.Button btnMaths;
        private System.Windows.Forms.Button btnPhysique;
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
        private System.Windows.Forms.Timer timerChargementMenu;
        private System.Windows.Forms.PictureBox pictureBoxAccueil;
    }
}

