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
            label1 = new Label();
            textBoxBookName = new TextBox();
            radioButtonExistingAuthor = new RadioButton();
            radioButtonNewAuthor = new RadioButton();
            comboBoxExistingAuthor = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            groupBoxBook = new GroupBox();
            textBox2 = new TextBox();
            groupBoxAuthor = new GroupBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            panelMain.SuspendLayout();
            groupBoxBook.SuspendLayout();
            groupBoxAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 25);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Nazwa:";
            // 
            // textBoxBookName
            // 
            textBoxBookName.Location = new Point(83, 22);
            textBoxBookName.Name = "textBoxBookName";
            textBoxBookName.Size = new Size(212, 23);
            textBoxBookName.TabIndex = 1;
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
            // comboBoxExistingAuthor
            // 
            comboBoxExistingAuthor.FormattingEnabled = true;
            comboBoxExistingAuthor.Location = new Point(83, 47);
            comboBoxExistingAuthor.Name = "comboBoxExistingAuthor";
            comboBoxExistingAuthor.Size = new Size(212, 23);
            comboBoxExistingAuthor.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 5;
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
            // groupBoxBook
            // 
            groupBoxBook.Controls.Add(pictureBox5);
            groupBoxBook.Controls.Add(pictureBox4);
            groupBoxBook.Controls.Add(pictureBox3);
            groupBoxBook.Controls.Add(pictureBox2);
            groupBoxBook.Controls.Add(pictureBox1);
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
            // textBox2
            // 
            textBox2.Location = new Point(83, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 23);
            textBox2.TabIndex = 7;
            // 
            // groupBoxAuthor
            // 
            groupBoxAuthor.Controls.Add(label3);
            groupBoxAuthor.Controls.Add(textBox2);
            groupBoxAuthor.Controls.Add(textBox1);
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_star;
            pictureBox1.Location = new Point(83, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.white_star;
            pictureBox2.Location = new Point(119, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(155, 51);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.white_star;
            pictureBox4.Location = new Point(191, 51);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.white_star;
            pictureBox5.Location = new Point(227, 51);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // ControlAddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Name = "ControlAddBook";
            Size = new Size(586, 332);
            panelMain.ResumeLayout(false);
            groupBoxBook.ResumeLayout(false);
            groupBoxBook.PerformLayout();
            groupBoxAuthor.ResumeLayout(false);
            groupBoxAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private TextBox textBox1;
        private Label label2;
        private GroupBox groupBoxAuthor;
        private TextBox textBox2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}
