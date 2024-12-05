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
            searchBookTextBox = new System.Windows.Forms.TextBox();
            booksFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            bookPanel = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            bookAuthorLabel = new System.Windows.Forms.Label();
            bookTitleLabel = new System.Windows.Forms.Label();
            topToolbar.SuspendLayout();
            booksFlowLayoutPanel.SuspendLayout();
            bookPanel.SuspendLayout();
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
            // 
            // topToolbar
            // 
            topToolbar.BackColor = System.Drawing.SystemColors.GrayText;
            topToolbar.Controls.Add(manageBookBorrowingsButton);
            topToolbar.Location = new System.Drawing.Point(1, 1);
            topToolbar.Name = "topToolbar";
            topToolbar.Size = new System.Drawing.Size(800, 49);
            topToolbar.TabIndex = 2;
            // 
            // searchBookTextBox
            // 
            searchBookTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            searchBookTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            searchBookTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            searchBookTextBox.ForeColor = System.Drawing.Color.White;
            searchBookTextBox.Location = new System.Drawing.Point(27, 66);
            searchBookTextBox.Multiline = true;
            searchBookTextBox.Name = "searchBookTextBox";
            searchBookTextBox.Size = new System.Drawing.Size(211, 37);
            searchBookTextBox.TabIndex = 3;
            searchBookTextBox.Text = "Recherche";
            // 
            // booksFlowLayoutPanel
            // 
            booksFlowLayoutPanel.AutoScroll = true;
            booksFlowLayoutPanel.Controls.Add(bookPanel);
            booksFlowLayoutPanel.Location = new System.Drawing.Point(27, 109);
            booksFlowLayoutPanel.Name = "booksFlowLayoutPanel";
            booksFlowLayoutPanel.Size = new System.Drawing.Size(761, 329);
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
            bookPanel.Size = new System.Drawing.Size(758, 122);
            bookPanel.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.White;
            button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Location = new System.Drawing.Point(541, 62);
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
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(booksFlowLayoutPanel);
            Controls.Add(searchBookTextBox);
            Controls.Add(topToolbar);
            Name = "Form3";
            Text = "Form3";
            topToolbar.ResumeLayout(false);
            booksFlowLayoutPanel.ResumeLayout(false);
            bookPanel.ResumeLayout(false);
            bookPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button manageBookBorrowingsButton;
        private System.Windows.Forms.Panel topToolbar;
        private System.Windows.Forms.TextBox searchBookTextBox;
        private System.Windows.Forms.FlowLayoutPanel booksFlowLayoutPanel;
        private System.Windows.Forms.Panel bookPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label bookAuthorLabel;
        private System.Windows.Forms.Label bookTitleLabel;
    }
}