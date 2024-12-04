namespace Projet
{
    partial class Form2
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
            manageBookBorrowingsButton = new System.Windows.Forms.Button();
            topToolbar = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton3 = new System.Windows.Forms.RadioButton();
            button3 = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            topToolbar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // manageBookBorrowingsButton
            // 
            manageBookBorrowingsButton.BackColor = System.Drawing.SystemColors.HighlightText;
            manageBookBorrowingsButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            manageBookBorrowingsButton.ForeColor = System.Drawing.Color.Black;
            manageBookBorrowingsButton.Location = new System.Drawing.Point(9, 3);
            manageBookBorrowingsButton.Name = "manageBookBorrowingsButton";
            manageBookBorrowingsButton.Size = new System.Drawing.Size(255, 43);
            manageBookBorrowingsButton.TabIndex = 2;
            manageBookBorrowingsButton.Text = "← Retour a la recherche";
            manageBookBorrowingsButton.UseVisualStyleBackColor = false;
            manageBookBorrowingsButton.Click += manageBookBorrowingsButton_Click;
            // 
            // topToolbar
            // 
            topToolbar.BackColor = System.Drawing.SystemColors.GrayText;
            topToolbar.Controls.Add(button2);
            topToolbar.Controls.Add(manageBookBorrowingsButton);
            topToolbar.Location = new System.Drawing.Point(3, 2);
            topToolbar.Name = "topToolbar";
            topToolbar.Size = new System.Drawing.Size(800, 49);
            topToolbar.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(12, 71);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(384, 328);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button3);
            panel2.Location = new System.Drawing.Point(422, 71);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(366, 328);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            button1.Location = new System.Drawing.Point(591, 405);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(197, 33);
            button1.TabIndex = 0;
            button1.Text = "Confirmer la reservation";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.LightSteelBlue;
            button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Location = new System.Drawing.Point(508, 2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(285, 43);
            button2.TabIndex = 3;
            button2.Text = "📕 Gérer les emprunts";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(25, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(228, 28);
            label1.TabIndex = 0;
            label1.Text = "Titre du Livre selectionne";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.DarkGreen;
            label3.Location = new System.Drawing.Point(25, 61);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(204, 15);
            label3.TabIndex = 2;
            label3.Text = "✓ Ressource disponible - Rayon Polar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(25, 123);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(153, 15);
            label2.TabIndex = 1;
            label2.Text = "Date du debut de l'emprunt";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(29, 185);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 15);
            label4.TabIndex = 3;
            label4.Text = "Date de retour";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(139, 185);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(69, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Un mois";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(139, 210);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(81, 19);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "Deux mois";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(139, 235);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(78, 19);
            radioButton3.TabIndex = 6;
            radioButton3.Text = "Trois mois";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            button3.Location = new System.Drawing.Point(89, 83);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(197, 33);
            button3.TabIndex = 1;
            button3.Text = "🔎 Chercher un abonne";
            button3.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(22, 35);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(173, 28);
            label5.TabIndex = 2;
            label5.Text = "Choisir l'utilisateur";
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(topToolbar);
            Name = "Form2";
            Text = "Form2";
            topToolbar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button manageBookBorrowingsButton;
        private System.Windows.Forms.Panel topToolbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}