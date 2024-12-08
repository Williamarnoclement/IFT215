namespace Projet
{
    partial class Form3
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
            booksFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            bookPanel = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            bookAuthorLabel = new System.Windows.Forms.Label();
            bookTitleLabel = new System.Windows.Forms.Label();
            leftToolbarPanel = new System.Windows.Forms.Panel();
            searchTextBox = new System.Windows.Forms.TextBox();
            topToolbar.SuspendLayout();
            booksFlowLayoutPanel.SuspendLayout();
            bookPanel.SuspendLayout();
            leftToolbarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // manageBookBorrowingsButton
            // 
            manageBookBorrowingsButton.BackColor = System.Drawing.SystemColors.HighlightText;
            manageBookBorrowingsButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            manageBookBorrowingsButton.ForeColor = System.Drawing.Color.Black;
            manageBookBorrowingsButton.Location = new System.Drawing.Point(5, 6);
            manageBookBorrowingsButton.Name = "manageBookBorrowingsButton";
            manageBookBorrowingsButton.Size = new System.Drawing.Size(255, 43);
            manageBookBorrowingsButton.TabIndex = 2;
            manageBookBorrowingsButton.Text = "← Retour à la recherche";
            manageBookBorrowingsButton.UseVisualStyleBackColor = false;
            manageBookBorrowingsButton.Click += manageBookBorrowingsButton_Click;
            // 
            // topToolbar
            // 
            topToolbar.BackColor = System.Drawing.SystemColors.GrayText;
            topToolbar.Controls.Add(manageBookBorrowingsButton);
            topToolbar.Location = new System.Drawing.Point(1, 1);
            topToolbar.Name = "topToolbar";
            topToolbar.Size = new System.Drawing.Size(800, 56);
            topToolbar.TabIndex = 2;
            // 
            // booksFlowLayoutPanel
            // 
            booksFlowLayoutPanel.AutoScroll = true;
            booksFlowLayoutPanel.Controls.Add(bookPanel);
            booksFlowLayoutPanel.Location = new System.Drawing.Point(13, 112);
            booksFlowLayoutPanel.Name = "booksFlowLayoutPanel";
            booksFlowLayoutPanel.Size = new System.Drawing.Size(700, 329);
            booksFlowLayoutPanel.TabIndex = 7;
            // 
            // bookPanel
            // 
            bookPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            bookPanel.Controls.Add(button2);
            bookPanel.Controls.Add(bookAuthorLabel);
            bookPanel.Controls.Add(bookTitleLabel);
            bookPanel.Location = new System.Drawing.Point(3, 3);
            bookPanel.Name = "bookPanel";
            bookPanel.Size = new System.Drawing.Size(600, 122);
            bookPanel.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.White;
            button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Location = new System.Drawing.Point(386, 64);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(199, 43);
            button2.TabIndex = 3;
            button2.Text = "Ramener Livre";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            // leftToolbarPanel
            // 
            leftToolbarPanel.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            leftToolbarPanel.Controls.Add(searchTextBox);
            leftToolbarPanel.Location = new System.Drawing.Point(1, 56);
            leftToolbarPanel.Name = "leftToolbarPanel";
            leftToolbarPanel.Size = new System.Drawing.Size(800, 50);
            leftToolbarPanel.TabIndex = 8;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = System.Drawing.Color.White;
            searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            searchTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            searchTextBox.ForeColor = System.Drawing.Color.Black;
            searchTextBox.Location = new System.Drawing.Point(12, 7);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Chercher une réservation...";
            searchTextBox.Size = new System.Drawing.Size(300, 35);
            searchTextBox.TabIndex = 0;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(leftToolbarPanel);
            Controls.Add(booksFlowLayoutPanel);
            Controls.Add(topToolbar);
            Name = "Form3";
            Size = new System.Drawing.Size(800, 450);
            topToolbar.ResumeLayout(false);
            booksFlowLayoutPanel.ResumeLayout(false);
            bookPanel.ResumeLayout(false);
            bookPanel.PerformLayout();
            leftToolbarPanel.ResumeLayout(false);
            leftToolbarPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button manageBookBorrowingsButton;
        private System.Windows.Forms.Panel topToolbar;
        private System.Windows.Forms.FlowLayoutPanel booksFlowLayoutPanel;
        private System.Windows.Forms.Panel bookPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label bookAuthorLabel;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.Panel leftToolbarPanel;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}