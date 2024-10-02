namespace BookTracer.Controls
{
    partial class FormMain
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
            buttonImport = new Button();
            buttonAddBook = new Button();
            buttonAuthorList = new Button();
            buttonBookList = new Button();
            panelAppName = new Panel();
            label1 = new Label();
            panelFormTopTitle = new Panel();
            labelStart = new Label();
            panelForControls = new Panel();
            panelLeft.SuspendLayout();
            panelAppName.SuspendLayout();
            panelFormTopTitle.SuspendLayout();
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
            buttonImport.Click += buttonImport_Click;
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
            buttonAddBook.Click += buttonAddBook_Click;
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
            buttonAuthorList.Click += buttonAuthorList_Click;
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
            buttonBookList.Click += buttonBookList_Click;
            // 
            // panelAppName
            // 
            panelAppName.BackColor = Color.FromArgb(39, 39, 58);
            panelAppName.Controls.Add(label1);
            panelAppName.Dock = DockStyle.Top;
            panelAppName.Location = new Point(0, 0);
            panelAppName.Name = "panelAppName";
            panelAppName.Size = new Size(130, 91);
            panelAppName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(21, 34);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 1;
            label1.Text = "Book Tracer";
            // 
            // panelFormTopTitle
            // 
            panelFormTopTitle.BackColor = Color.FromArgb(0, 150, 136);
            panelFormTopTitle.Controls.Add(labelStart);
            panelFormTopTitle.Dock = DockStyle.Top;
            panelFormTopTitle.Location = new Point(130, 0);
            panelFormTopTitle.Name = "panelFormTopTitle";
            panelFormTopTitle.Size = new Size(670, 91);
            panelFormTopTitle.TabIndex = 1;
            // 
            // labelStart
            // 
            labelStart.Anchor = AnchorStyles.None;
            labelStart.AutoSize = true;
            labelStart.Font = new Font("Impact", 30F);
            labelStart.ForeColor = Color.White;
            labelStart.Location = new Point(273, 21);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(117, 48);
            labelStart.TabIndex = 0;
            labelStart.Text = "START";
            // 
            // panelForControls
            // 
            panelForControls.Dock = DockStyle.Fill;
            panelForControls.Location = new Point(130, 91);
            panelForControls.Name = "panelForControls";
            panelForControls.Size = new Size(670, 359);
            panelForControls.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelForControls);
            Controls.Add(panelFormTopTitle);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelLeft.ResumeLayout(false);
            panelAppName.ResumeLayout(false);
            panelAppName.PerformLayout();
            panelFormTopTitle.ResumeLayout(false);
            panelFormTopTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelAppName;
        private Button buttonBookList;
        private Button buttonAuthorList;
        private Button buttonAddBook;
        private Button buttonImport;
        private Label label1;
        private Panel panelFormTopTitle;
        private Label labelStart;
        private Panel panelForControls;
    }
}
