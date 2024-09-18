namespace BookTracer
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
            panelLeft = new Panel();
            panelAppName = new Panel();
            buttonBookList = new Button();
            buttonAuthorList = new Button();
            buttonAddBook = new Button();
            buttonImport = new Button();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(51, 51, 76);
            panelLeft.Controls.Add(buttonImport);
            panelLeft.Controls.Add(buttonAddBook);
            panelLeft.Controls.Add(buttonAuthorList);
            panelLeft.Controls.Add(buttonBookList);
            panelLeft.Controls.Add(panelAppName);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(130, 450);
            panelLeft.TabIndex = 0;
            // 
            // panelAppName
            // 
            panelAppName.BackColor = Color.FromArgb(39, 39, 58);
            panelAppName.Dock = DockStyle.Top;
            panelAppName.Location = new Point(0, 0);
            panelAppName.Name = "panelAppName";
            panelAppName.Size = new Size(130, 91);
            panelAppName.TabIndex = 1;
            // 
            // buttonBookList
            // 
            buttonBookList.Dock = DockStyle.Top;
            buttonBookList.FlatAppearance.BorderColor = Color.FromArgb(39, 39, 58);
            buttonBookList.FlatStyle = FlatStyle.Flat;
            buttonBookList.ForeColor = Color.Gainsboro;
            buttonBookList.Image = Properties.Resources.icons8_list_32;
            buttonBookList.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBookList.Location = new Point(0, 91);
            buttonBookList.Name = "buttonBookList";
            buttonBookList.Size = new Size(130, 60);
            buttonBookList.TabIndex = 1;
            buttonBookList.Text = " Lista książek";
            buttonBookList.TextAlign = ContentAlignment.MiddleLeft;
            buttonBookList.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonBookList.UseVisualStyleBackColor = true;
            // 
            // buttonAuthorList
            // 
            buttonAuthorList.Dock = DockStyle.Top;
            buttonAuthorList.FlatAppearance.BorderColor = Color.FromArgb(39, 39, 58);
            buttonAuthorList.FlatStyle = FlatStyle.Flat;
            buttonAuthorList.ForeColor = Color.Gainsboro;
            buttonAuthorList.Image = Properties.Resources.icons8_books_32;
            buttonAuthorList.Location = new Point(0, 151);
            buttonAuthorList.Name = "buttonAuthorList";
            buttonAuthorList.Size = new Size(130, 60);
            buttonAuthorList.TabIndex = 1;
            buttonAuthorList.Text = " Lista autorów";
            buttonAuthorList.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAuthorList.UseVisualStyleBackColor = true;
            // 
            // buttonAddBook
            // 
            buttonAddBook.Dock = DockStyle.Top;
            buttonAddBook.FlatAppearance.BorderColor = Color.FromArgb(39, 39, 58);
            buttonAddBook.FlatStyle = FlatStyle.Flat;
            buttonAddBook.ForeColor = Color.Gainsboro;
            buttonAddBook.Image = Properties.Resources.icons8_add_database_32;
            buttonAddBook.Location = new Point(0, 211);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(130, 60);
            buttonAddBook.TabIndex = 2;
            buttonAddBook.Text = " Dodaj książkę";
            buttonAddBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddBook.UseVisualStyleBackColor = true;
            // 
            // buttonImport
            // 
            buttonImport.Dock = DockStyle.Top;
            buttonImport.FlatAppearance.BorderColor = Color.FromArgb(39, 39, 58);
            buttonImport.FlatStyle = FlatStyle.Flat;
            buttonImport.ForeColor = Color.Gainsboro;
            buttonImport.Image = Properties.Resources.icons8_database_import_32;
            buttonImport.Location = new Point(0, 271);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(130, 60);
            buttonImport.TabIndex = 3;
            buttonImport.Text = " Importuj";
            buttonImport.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonImport.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelAppName;
        private Button buttonBookList;
        private Button buttonAuthorList;
        private Button buttonAddBook;
        private Button buttonImport;
    }
}
