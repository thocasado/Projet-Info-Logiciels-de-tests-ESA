﻿namespace Projet_GenieLog.View
{
    partial class FormCalculMental
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
            this.label1 = new System.Windows.Forms.Label();
            this.additionButton = new System.Windows.Forms.Button();
            this.sousButton = new System.Windows.Forms.Button();
            this.multButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.MaximumSize = new System.Drawing.Size(508, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vous allez devoir réaliser des calculs mentaux. Sélectionner l\'opération souhaité" +
    "e !";
            // 
            // additionButton
            // 
            this.additionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.additionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.additionButton.Location = new System.Drawing.Point(63, 140);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(102, 79);
            this.additionButton.TabIndex = 1;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // sousButton
            // 
            this.sousButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.sousButton.Location = new System.Drawing.Point(301, 140);
            this.sousButton.Name = "sousButton";
            this.sousButton.Size = new System.Drawing.Size(102, 79);
            this.sousButton.TabIndex = 2;
            this.sousButton.Text = "-";
            this.sousButton.UseVisualStyleBackColor = true;
            this.sousButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // multButton
            // 
            this.multButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.multButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.multButton.Location = new System.Drawing.Point(63, 272);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(102, 79);
            this.multButton.TabIndex = 1;
            this.multButton.Text = "x";
            this.multButton.UseVisualStyleBackColor = true;
            this.multButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // divButton
            // 
            this.divButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.divButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.divButton.Location = new System.Drawing.Point(301, 272);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(102, 79);
            this.divButton.TabIndex = 2;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.operationButton_Click);
            // 
            // FormCalculMental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(492, 407);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.sousButton);
            this.Controls.Add(this.multButton);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.label1);
            this.Name = "FormCalculMental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCalculMental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button sousButton;
        private System.Windows.Forms.Button multButton;
        private System.Windows.Forms.Button divButton;
    }
}