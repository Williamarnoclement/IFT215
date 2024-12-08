namespace Projet
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new System.Windows.Forms.Label();
            StateComboBox = new System.Windows.Forms.ComboBox();
            BouttonConfirmer = new System.Windows.Forms.Button();
            BoutonAnnuler = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // StateComboBox
            // 
            resources.ApplyResources(StateComboBox, "StateComboBox");
            StateComboBox.FormattingEnabled = true;
            StateComboBox.Name = "StateComboBox";
            StateComboBox.SelectedIndexChanged += StateComboBox_SelectedIndexChanged;
            // 
            // BouttonConfirmer
            // 
            resources.ApplyResources(BouttonConfirmer, "BouttonConfirmer");
            BouttonConfirmer.Name = "BouttonConfirmer";
            BouttonConfirmer.UseVisualStyleBackColor = true;
            BouttonConfirmer.Click += BouttonConfirmer_Click;
            // 
            // BoutonAnnuler
            // 
            resources.ApplyResources(BoutonAnnuler, "BoutonAnnuler");
            BoutonAnnuler.Name = "BoutonAnnuler";
            BoutonAnnuler.UseVisualStyleBackColor = true;
            BoutonAnnuler.Click += BoutonAnnuler_Click;
            // 
            // Form4
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(BoutonAnnuler);
            Controls.Add(BouttonConfirmer);
            Controls.Add(StateComboBox);
            Controls.Add(label1);
            Name = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StateComboBox;
        private System.Windows.Forms.Button BouttonConfirmer;
        private System.Windows.Forms.Button BoutonAnnuler;
    }
}