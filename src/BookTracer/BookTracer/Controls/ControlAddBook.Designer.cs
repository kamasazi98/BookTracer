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
            buttonAdd = new Button();
            label3 = new Label();
            textBoxAuthorLastName = new TextBox();
            textBoxAuthorFirstName = new TextBox();
            label2 = new Label();
            radioButtonExistingAuthor = new RadioButton();
            comboBoxExistingAuthor = new ComboBox();
            radioButtonNewAuthor = new RadioButton();
            pictureBoxFifthStar = new PictureBox();
            pictureBoxFourthStar = new PictureBox();
            pictureBoxThridStar = new PictureBox();
            pictureBoxSecondStar = new PictureBox();
            pictureBoxFirstStar = new PictureBox();
            textBoxBookName = new TextBox();
            label1 = new Label();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFifthStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFourthStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThridStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSecondStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFirstStar).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(buttonAdd);
            panelMain.Controls.Add(pictureBoxFifthStar);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(textBoxAuthorLastName);
            panelMain.Controls.Add(pictureBoxFourthStar);
            panelMain.Controls.Add(textBoxAuthorFirstName);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(pictureBoxThridStar);
            panelMain.Controls.Add(radioButtonExistingAuthor);
            panelMain.Controls.Add(textBoxBookName);
            panelMain.Controls.Add(comboBoxExistingAuthor);
            panelMain.Controls.Add(pictureBoxSecondStar);
            panelMain.Controls.Add(radioButtonNewAuthor);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(pictureBoxFirstStar);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(586, 332);
            panelMain.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(108, 200);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(212, 23);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Dodaj";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 174);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 8;
            label3.Text = "Nazwisko autora:";
            // 
            // textBoxAuthorLastName
            // 
            textBoxAuthorLastName.Location = new Point(108, 171);
            textBoxAuthorLastName.Name = "textBoxAuthorLastName";
            textBoxAuthorLastName.Size = new Size(212, 23);
            textBoxAuthorLastName.TabIndex = 7;
            // 
            // textBoxAuthorFirstName
            // 
            textBoxAuthorFirstName.Location = new Point(108, 142);
            textBoxAuthorFirstName.Name = "textBoxAuthorFirstName";
            textBoxAuthorFirstName.Size = new Size(212, 23);
            textBoxAuthorFirstName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 145);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 6;
            label2.Text = "Imię autora:";
            // 
            // radioButtonExistingAuthor
            // 
            radioButtonExistingAuthor.AutoSize = true;
            radioButtonExistingAuthor.Location = new Point(108, 88);
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
            comboBoxExistingAuthor.Location = new Point(108, 113);
            comboBoxExistingAuthor.Name = "comboBoxExistingAuthor";
            comboBoxExistingAuthor.Size = new Size(212, 23);
            comboBoxExistingAuthor.TabIndex = 4;
            // 
            // radioButtonNewAuthor
            // 
            radioButtonNewAuthor.AutoSize = true;
            radioButtonNewAuthor.Location = new Point(233, 88);
            radioButtonNewAuthor.Name = "radioButtonNewAuthor";
            radioButtonNewAuthor.Size = new Size(87, 19);
            radioButtonNewAuthor.TabIndex = 3;
            radioButtonNewAuthor.TabStop = true;
            radioButtonNewAuthor.Text = "Nowy autor";
            radioButtonNewAuthor.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFifthStar
            // 
            pictureBoxFifthStar.Image = Properties.Resources.white_star;
            pictureBoxFifthStar.Location = new Point(267, 42);
            pictureBoxFifthStar.Name = "pictureBoxFifthStar";
            pictureBoxFifthStar.Size = new Size(30, 30);
            pictureBoxFifthStar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFifthStar.TabIndex = 6;
            pictureBoxFifthStar.TabStop = false;
            // 
            // pictureBoxFourthStar
            // 
            pictureBoxFourthStar.Image = Properties.Resources.white_star;
            pictureBoxFourthStar.Location = new Point(231, 42);
            pictureBoxFourthStar.Name = "pictureBoxFourthStar";
            pictureBoxFourthStar.Size = new Size(30, 30);
            pictureBoxFourthStar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFourthStar.TabIndex = 5;
            pictureBoxFourthStar.TabStop = false;
            // 
            // pictureBoxThridStar
            // 
            pictureBoxThridStar.Image = Properties.Resources.white_star;
            pictureBoxThridStar.Location = new Point(195, 42);
            pictureBoxThridStar.Name = "pictureBoxThridStar";
            pictureBoxThridStar.Size = new Size(30, 30);
            pictureBoxThridStar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxThridStar.TabIndex = 4;
            pictureBoxThridStar.TabStop = false;
            // 
            // pictureBoxSecondStar
            // 
            pictureBoxSecondStar.Image = Properties.Resources.white_star;
            pictureBoxSecondStar.Location = new Point(159, 42);
            pictureBoxSecondStar.Name = "pictureBoxSecondStar";
            pictureBoxSecondStar.Size = new Size(30, 30);
            pictureBoxSecondStar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxSecondStar.TabIndex = 3;
            pictureBoxSecondStar.TabStop = false;
            // 
            // pictureBoxFirstStar
            // 
            pictureBoxFirstStar.Image = Properties.Resources.white_star;
            pictureBoxFirstStar.Location = new Point(123, 42);
            pictureBoxFirstStar.Name = "pictureBoxFirstStar";
            pictureBoxFirstStar.Size = new Size(30, 30);
            pictureBoxFirstStar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFirstStar.TabIndex = 2;
            pictureBoxFirstStar.TabStop = false;
            // 
            // textBoxBookName
            // 
            textBoxBookName.Location = new Point(108, 13);
            textBoxBookName.Name = "textBoxBookName";
            textBoxBookName.Size = new Size(212, 23);
            textBoxBookName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Nazwa książki:";
            // 
            // ControlAddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Name = "ControlAddBook";
            Size = new Size(586, 332);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
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
        private TextBox textBoxAuthorFirstName;
        private Label label2;
        private TextBox textBoxAuthorLastName;
        private Label label3;
        private PictureBox pictureBoxFirstStar;
        private PictureBox pictureBoxFifthStar;
        private PictureBox pictureBoxFourthStar;
        private PictureBox pictureBoxThridStar;
        private PictureBox pictureBoxSecondStar;
        private Button buttonAdd;
    }
}
