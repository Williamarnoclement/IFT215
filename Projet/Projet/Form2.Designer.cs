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
            button2 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            endDateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            userComboBox = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
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
            manageBookBorrowingsButton.Location = new System.Drawing.Point(5, 6);
            manageBookBorrowingsButton.Name = "manageBookBorrowingsButton";
            manageBookBorrowingsButton.Size = new System.Drawing.Size(285, 43);
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
            topToolbar.Size = new System.Drawing.Size(800, 56);
            topToolbar.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.LightSteelBlue;
            button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Location = new System.Drawing.Point(505, 6);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(285, 43);
            button2.TabIndex = 3;
            button2.Text = "📕 Gérer les emprunts";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            panel1.Controls.Add(endDateLabel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(startDateLabel);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(titleLabel);
            panel1.Location = new System.Drawing.Point(12, 71);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(384, 308);
            panel1.TabIndex = 2;
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            endDateLabel.Location = new System.Drawing.Point(178, 242);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(94, 21);
            endDateLabel.TabIndex = 9;
            endDateLabel.Text = "11-11-1111";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 128);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(160, 21);
            label1.TabIndex = 8;
            label1.Text = "Temps de réservation:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            startDateLabel.Location = new System.Drawing.Point(178, 74);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(94, 21);
            startDateLabel.TabIndex = 7;
            startDateLabel.Text = "11-11-1111";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(179, 206);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(81, 19);
            radioButton3.TabIndex = 6;
            radioButton3.Text = "Deux mois";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(179, 181);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(69, 19);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "Un mois";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(179, 156);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(93, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Une semaine";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(12, 242);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(113, 21);
            label4.TabIndex = 3;
            label4.Text = "Date de retour:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(12, 74);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(142, 21);
            label2.TabIndex = 1;
            label2.Text = "Date de l'emprunt :";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            titleLabel.Location = new System.Drawing.Point(45, 17);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(283, 32);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Titre du Livre selectionné";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            panel2.Controls.Add(nameLabel);
            panel2.Controls.Add(emailLabel);
            panel2.Controls.Add(phoneLabel);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(userComboBox);
            panel2.Controls.Add(label5);
            panel2.Location = new System.Drawing.Point(422, 71);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(366, 308);
            panel2.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nameLabel.Location = new System.Drawing.Point(128, 120);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(71, 21);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Grégoire";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            emailLabel.Location = new System.Drawing.Point(128, 150);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(155, 21);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "example@gmail.com";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            phoneLabel.Location = new System.Drawing.Point(128, 181);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(127, 21);
            phoneLabel.TabIndex = 10;
            phoneLabel.Text = "1-457-346-8489";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(35, 180);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(87, 21);
            label7.TabIndex = 12;
            label7.Text = "Téléphone :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(35, 150);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(69, 21);
            label6.TabIndex = 11;
            label6.Text = "Courriel:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(35, 120);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 21);
            label3.TabIndex = 10;
            label3.Text = "Nom :";
            // 
            // userComboBox
            // 
            userComboBox.FormattingEnabled = true;
            userComboBox.Location = new System.Drawing.Point(47, 61);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new System.Drawing.Size(284, 23);
            userComboBox.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(37, 17);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(294, 32);
            label5.TabIndex = 2;
            label5.Text = "Sélectionner un utilisateur";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(508, 395);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(285, 43);
            button1.TabIndex = 0;
            button1.Text = "Confirmer la reservation";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(topToolbar);
            Name = "Form2";
            Size = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label label7;
    }
}