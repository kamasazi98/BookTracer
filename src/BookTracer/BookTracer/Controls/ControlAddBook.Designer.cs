namespace BookTracer.Controls
{
    partial class ControlAddBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMain = new Panel();
            groupBoxAuthor = new GroupBox();
            label3 = new Label();
            textBoxAuthorLastName = new TextBox();
            textBoxAuthorFirstName = new TextBox();
            label2 = new Label();
            radioButtonExistingAuthor = new RadioButton();
            comboBoxExistingAuthor = new ComboBox();
            radioButtonNewAuthor = new RadioButton();
            groupBoxBook = new GroupBox();
            pictureBoxFifthStar = new PictureBox();
            pictureBoxFourthStar = new PictureBox();
            pictureBoxThridStar = new PictureBox();
            pictureBoxSecondStar = new PictureBox();
            pictureBoxFirstStar = new PictureBox();
            textBoxBookName = new TextBox();
            label1 = new Label();
            panelMain.SuspendLayout();
            groupBoxAuthor.SuspendLayout();
            groupBoxBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFifthStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFourthStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThridStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecondStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFirstStar).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(groupBoxAuthor);
            panelMain.Controls.Add(groupBoxBook);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(586, 332);
            panelMain.TabIndex = 0;
            // 
            // groupBoxAuthor
            // 
            groupBoxAuthor.Controls.Add(label3);
            groupBoxAuthor.Controls.Add(textBoxAuthorLastName);
            groupBoxAuthor.Controls.Add(textBoxAuthorFirstName);
            groupBoxAuthor.Controls.Add(label2);
            groupBoxAuthor.Controls.Add(radioButtonExistingAuthor);
            groupBoxAuthor.Controls.Add(comboBoxExistingAuthor);
            groupBoxAuthor.Controls.Add(radioButtonNewAuthor);
            groupBoxAuthor.Dock = DockStyle.Fill;
            groupBoxAuthor.Location = new Point(0, 96);
            groupBoxAuthor.Name = "groupBoxAuthor";
            groupBoxAuthor.Size = new Size(586, 236);
            groupBoxAuthor.TabIndex = 7;
            groupBoxAuthor.TabStop = false;
            groupBoxAuthor.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 108);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Nazwisko:";
            // 
            // textBoxAuthorLastName
            // 
            textBoxAuthorLastName.Location = new Point(83, 105);
            textBoxAuthorLastName.Name = "textBoxAuthorLastName";
            textBoxAuthorLastName.Size = new Size(212, 23);
            textBoxAuthorLastName.TabIndex = 7;
            // 
            // textBoxAuthorFirstName
            // 
            textBoxAuthorFirstName.Location = new Point(83, 76);
            textBoxAuthorFirstName.Name = "textBoxAuthorFirstName";
            textBoxAuthorFirstName.Size = new Size(212, 23);
            textBoxAuthorFirstName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 79);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 6;
            label2.Text = "Imię:";
            // 
            // radioButtonExistingAuthor
            // 
            radioButtonExistingAuthor.AutoSize = true;
            radioButtonExistingAuthor.Location = new Point(83, 22);
            radioButtonExistingAuthor.Name = "radioButtonExistingAuthor";
            radioButtonExistingAuthor.Size = new Size(105, 19);
            radioButtonExistingAuthor.TabIndex = 2;
            radioButtonExistingAuthor.TabStop = true;
            radioButtonExistingAuthor.Text = "Istniejący autor";
            radioButtonExistingAuthor.UseVisualStyleBackColor = true;
            // 
            // comboBoxExistingAuthor
            // 
            comboBoxExistingAuthor.FormattingEnabled = true;
            comboBoxExistingAuthor.Location = new Point(83, 47);
            comboBoxExistingAuthor.Name = "comboBoxExistingAuthor";
            comboBoxExistingAuthor.Size = new Size(212, 23);
            comboBoxExistingAuthor.TabIndex = 4;
            // 
            // radioButtonNewAuthor
            // 
            radioButtonNewAuthor.AutoSize = true;
            radioButtonNewAuthor.Location = new Point(208, 22);
            radioButtonNewAuthor.Name = "radioButtonNewAuthor";
            radioButtonNewAuthor.Size = new Size(87, 19);
            radioButtonNewAuthor.TabIndex = 3;
            radioButtonNewAuthor.TabStop = true;
            radioButtonNewAuthor.Text = "Nowy autor";
            radioButtonNewAuthor.UseVisualStyleBackColor = true;
            // 
            // groupBoxBook
            // 
            groupBoxBook.Controls.Add(pictureBoxFifthStar);
            groupBoxBook.Controls.Add(pictureBoxFourthStar);
            groupBoxBook.Controls.Add(pictureBoxThridStar);
            groupBoxBook.Controls.Add(pictureBoxSecondStar);
            groupBoxBook.Controls.Add(pictureBoxFirstStar);
            groupBoxBook.Controls.Add(textBoxBookName);
            groupBoxBook.Controls.Add(label1);
            groupBoxBook.Dock = DockStyle.Top;
            groupBoxBook.Location = new Point(0, 0);
            groupBoxBook.Name = "groupBoxBook";
            groupBoxBook.Size = new Size(586, 96);
            groupBoxBook.TabIndex = 8;
            groupBoxBook.TabStop = false;
            groupBoxBook.Text = "Książka";
            // 
            // pictureBoxFifthStar
            // 
            pictureBoxFifthStar.Image = Properties.Resources.white_star;
            pictureBoxFifthStar.Location = new Point(227, 51);
            pictureBoxFifthStar.Name = "pictureBoxFifthStar";
            pictureBoxFifthStar.Size = new Size(30, 30);
            pictureBoxFifthStar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFifthStar.TabIndex = 6;
            pictureBoxFifthStar.TabStop = false;
            // 
            // pictureBoxFourthStar
            // 
            pictureBoxFourthStar.Image = Properties.Resources.white_star;
            pictureBoxFourthStar.Location = new Point(191, 51);
            pictureBoxFourthStar.Name = "pictureBoxFourthStar";
            pictureBoxFourthStar.Size = new Size(30, 30);
            pictureBoxFourthStar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFourthStar.TabIndex = 5;
            pictureBoxFourthStar.TabStop = false;
            // 
            // pictureBoxThridStar
            // 
            pictureBoxThridStar.Image = Properties.Resources.white_star;
            pictureBoxThridStar.Location = new Point(155, 51);
            pictureBoxThridStar.Name = "pictureBoxThridStar";
            pictureBoxThridStar.Size = new Size(30, 30);
            pictureBoxThridStar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxThridStar.TabIndex = 4;
            pictureBoxThridStar.TabStop = false;
            // 
            // pictureBoxSecondStar
            // 
            pictureBoxSecondStar.Image = Properties.Resources.white_star;
            pictureBoxSecondStar.Location = new Point(119, 51);
            pictureBoxSecondStar.Name = "pictureBoxSecondStar";
            pictureBoxSecondStar.Size = new Size(30, 30);
            pictureBoxSecondStar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSecondStar.TabIndex = 3;
            pictureBoxSecondStar.TabStop = false;
            // 
            // pictureBoxFirstStar
            // 
            pictureBoxFirstStar.Image = Properties.Resources.white_star;
            pictureBoxFirstStar.Location = new Point(83, 51);
            pictureBoxFirstStar.Name = "pictureBoxFirstStar";
            pictureBoxFirstStar.Size = new Size(30, 30);
            pictureBoxFirstStar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFirstStar.TabIndex = 2;
            pictureBoxFirstStar.TabStop = false;
            // 
            // textBoxBookName
            // 
            textBoxBookName.Location = new Point(83, 22);
            textBoxBookName.Name = "textBoxBookName";
            textBoxBookName.Size = new Size(212, 23);
            textBoxBookName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 25);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Nazwa:";
            // 
            // ControlAddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Name = "ControlAddBook";
            Size = new Size(586, 332);
            panelMain.ResumeLayout(false);
            groupBoxAuthor.ResumeLayout(false);
            groupBoxAuthor.PerformLayout();
            groupBoxBook.ResumeLayout(false);
            groupBoxBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFifthStar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFourthStar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThridStar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecondStar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFirstStar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private TextBox textBoxBookName;
        private Label label1;
        private RadioButton radioButtonNewAuthor;
        private RadioButton radioButtonExistingAuthor;
        private ComboBox comboBoxExistingAuthor;
        private GroupBox groupBoxBook;
        private TextBox textBoxAuthorFirstName;
        private Label label2;
        private GroupBox groupBoxAuthor;
        private TextBox textBoxAuthorLastName;
        private Label label3;
        private PictureBox pictureBoxFirstStar;
        private PictureBox pictureBoxFifthStar;
        private PictureBox pictureBoxFourthStar;
        private PictureBox pictureBoxThridStar;
        private PictureBox pictureBoxSecondStar;
    }
}
