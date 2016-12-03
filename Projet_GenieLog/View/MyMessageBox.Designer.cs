namespace Projet_GenieLog.View
{
    partial class MyMessageBox
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
            this.textBoxMMB = new System.Windows.Forms.TextBox();
            this.labelMMB = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMMB
            // 
            this.textBoxMMB.Location = new System.Drawing.Point(74, 106);
            this.textBoxMMB.Name = "textBoxMMB";
            this.textBoxMMB.Size = new System.Drawing.Size(100, 20);
            this.textBoxMMB.TabIndex = 0;
            // 
            // labelMMB
            // 
            this.labelMMB.AutoSize = true;
            this.labelMMB.Location = new System.Drawing.Point(74, 56);
            this.labelMMB.Name = "labelMMB";
            this.labelMMB.Size = new System.Drawing.Size(35, 13);
            this.labelMMB.TabIndex = 1;
            this.labelMMB.Text = "label1";
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(88, 149);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 2;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            // 
            // MyMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 212);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.labelMMB);
            this.Controls.Add(this.textBoxMMB);
            this.Name = "MyMessageBox";
            this.Text = "MyMessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMMB;
        private System.Windows.Forms.Label labelMMB;
        private System.Windows.Forms.Button buttonValider;
    }
}