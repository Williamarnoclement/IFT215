namespace Projet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            topToolbar = new System.Windows.Forms.Panel();
            manageBookBorrowingsButton = new System.Windows.Forms.Button();
            leftToolbarPanel = new System.Windows.Forms.Panel();
            typePanel = new System.Windows.Forms.Panel();
            typeComboBox = new System.Windows.Forms.ComboBox();
            typeLabel = new System.Windows.Forms.Label();
            agePanel = new System.Windows.Forms.Panel();
            ageComboBox = new System.Windows.Forms.ComboBox();
            ageLabel = new System.Windows.Forms.Label();
            searchBookTextBox = new System.Windows.Forms.TextBox();
            booksFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            bookPanel = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            bookAuthorLabel = new System.Windows.Forms.Label();
            bookTitleLabel = new System.Windows.Forms.Label();
            topToolbar.SuspendLayout();
            leftToolbarPanel.SuspendLayout();
            typePanel.SuspendLayout();
            agePanel.SuspendLayout();
            booksFlowLayoutPanel.SuspendLayout();
            bookPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topToolbar
            // 
            topToolbar.BackColor = System.Drawing.SystemColors.GrayText;
            topToolbar.Controls.Add(manageBookBorrowingsButton);
            topToolbar.Location = new System.Drawing.Point(0, 0);
            topToolbar.Name = "topToolbar";
            topToolbar.Size = new System.Drawing.Size(800, 56);
            topToolbar.TabIndex = 0;
            // 
            // manageBookBorrowingsButton
            // 
            manageBookBorrowingsButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            manageBookBorrowingsButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            manageBookBorrowingsButton.ForeColor = System.Drawing.Color.White;
            manageBookBorrowingsButton.Location = new System.Drawing.Point(99, 6);
            manageBookBorrowingsButton.Name = "manageBookBorrowingsButton";
            manageBookBorrowingsButton.Size = new System.Drawing.Size(245, 43);
            manageBookBorrowingsButton.TabIndex = 2;
            manageBookBorrowingsButton.Text = "Gérer les emprunts";
            manageBookBorrowingsButton.UseVisualStyleBackColor = false;
            // 
            // leftToolbarPanel
            // 
            leftToolbarPanel.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            leftToolbarPanel.Controls.Add(typePanel);
            leftToolbarPanel.Controls.Add(agePanel);
            leftToolbarPanel.Controls.Add(searchBookTextBox);
            leftToolbarPanel.Location = new System.Drawing.Point(0, 55);
            leftToolbarPanel.Name = "leftToolbarPanel";
            leftToolbarPanel.Size = new System.Drawing.Size(257, 395);
            leftToolbarPanel.TabIndex = 1;
            // 
            // typePanel
            // 
            typePanel.AutoSize = true;
            typePanel.Controls.Add(typeComboBox);
            typePanel.Controls.Add(typeLabel);
            typePanel.Location = new System.Drawing.Point(23, 144);
            typePanel.Name = "typePanel";
            typePanel.Size = new System.Drawing.Size(218, 61);
            typePanel.TabIndex = 5;
            // 
            // typeComboBox
            // 
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Location = new System.Drawing.Point(3, 35);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new System.Drawing.Size(212, 23);
            typeComboBox.TabIndex = 4;
            // 
            // typeLabel
            // 
            typeLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            typeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            typeLabel.ForeColor = System.Drawing.Color.White;
            typeLabel.Location = new System.Drawing.Point(3, 0);
            typeLabel.Margin = new System.Windows.Forms.Padding(0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(212, 32);
            typeLabel.TabIndex = 3;
            typeLabel.Text = "Type";
            typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // agePanel
            // 
            agePanel.AutoSize = true;
            agePanel.Controls.Add(ageComboBox);
            agePanel.Controls.Add(ageLabel);
            agePanel.Location = new System.Drawing.Point(23, 77);
            agePanel.Name = "agePanel";
            agePanel.Size = new System.Drawing.Size(218, 61);
            agePanel.TabIndex = 3;
            // 
            // ageComboBox
            // 
            ageComboBox.FormattingEnabled = true;
            ageComboBox.Location = new System.Drawing.Point(3, 35);
            ageComboBox.Name = "ageComboBox";
            ageComboBox.Size = new System.Drawing.Size(212, 23);
            ageComboBox.TabIndex = 4;
            // 
            // ageLabel
            // 
            ageLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            ageLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ageLabel.ForeColor = System.Drawing.Color.White;
            ageLabel.Location = new System.Drawing.Point(3, 0);
            ageLabel.Margin = new System.Windows.Forms.Padding(0);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(212, 32);
            ageLabel.TabIndex = 3;
            ageLabel.Text = "Âge";
            ageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBookTextBox
            // 
            searchBookTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            searchBookTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            searchBookTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            searchBookTextBox.ForeColor = System.Drawing.Color.White;
            searchBookTextBox.Location = new System.Drawing.Point(12, 13);
            searchBookTextBox.Multiline = true;
            searchBookTextBox.Name = "searchBookTextBox";
            searchBookTextBox.Size = new System.Drawing.Size(211, 37);
            searchBookTextBox.TabIndex = 0;
            searchBookTextBox.Text = "Recherche";
            // 
            // booksFlowLayoutPanel
            // 
            booksFlowLayoutPanel.AutoScroll = true;
            booksFlowLayoutPanel.Controls.Add(bookPanel);
            booksFlowLayoutPanel.Location = new System.Drawing.Point(288, 68);
            booksFlowLayoutPanel.Name = "booksFlowLayoutPanel";
            booksFlowLayoutPanel.Size = new System.Drawing.Size(491, 373);
            booksFlowLayoutPanel.TabIndex = 6;
            // 
            // bookPanel
            // 
            bookPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            bookPanel.Controls.Add(button2);
            bookPanel.Controls.Add(bookAuthorLabel);
            bookPanel.Controls.Add(bookTitleLabel);
            bookPanel.Location = new System.Drawing.Point(3, 3);
            bookPanel.Name = "bookPanel";
            bookPanel.Size = new System.Drawing.Size(467, 122);
            bookPanel.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.White;
            button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Location = new System.Drawing.Point(262, 70);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(199, 43);
            button2.TabIndex = 3;
            button2.Text = "Réserver";
            button2.UseVisualStyleBackColor = false;
            
            // 
            // bookAuthorLabel
            // 
            bookAuthorLabel.AutoEllipsis = true;
            bookAuthorLabel.AutoSize = true;
            bookAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bookAuthorLabel.ForeColor = System.Drawing.Color.White;
            bookAuthorLabel.Location = new System.Drawing.Point(13, 48);
            bookAuthorLabel.Margin = new System.Windows.Forms.Padding(0);
            bookAuthorLabel.Name = "bookAuthorLabel";
            bookAuthorLabel.Size = new System.Drawing.Size(75, 13);
            bookAuthorLabel.TabIndex = 1;
            bookAuthorLabel.Text = "Auteur du livre";
            bookAuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bookTitleLabel.ForeColor = System.Drawing.Color.White;
            bookTitleLabel.Location = new System.Drawing.Point(13, 9);
            bookTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new System.Drawing.Size(149, 32);
            bookTitleLabel.TabIndex = 0;
            bookTitleLabel.Text = "Titre du livre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(booksFlowLayoutPanel);
            Controls.Add(leftToolbarPanel);
            Controls.Add(topToolbar);
            Name = "Form1";
            Text = "Form1";
            topToolbar.ResumeLayout(false);
            leftToolbarPanel.ResumeLayout(false);
            leftToolbarPanel.PerformLayout();
            typePanel.ResumeLayout(false);
            agePanel.ResumeLayout(false);
            booksFlowLayoutPanel.ResumeLayout(false);
            bookPanel.ResumeLayout(false);
            bookPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel topToolbar;
        private System.Windows.Forms.Panel leftToolbarPanel;
        private System.Windows.Forms.TextBox searchBookTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Panel agePanel;
        private System.Windows.Forms.ComboBox ageComboBox;
        private System.Windows.Forms.Panel typePanel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.FlowLayoutPanel booksFlowLayoutPanel;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel bookPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.Label bookAuthorLabel;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button manageBookBorrowingsButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}
