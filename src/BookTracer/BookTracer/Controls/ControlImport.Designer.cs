namespace BookTracer.Controls
{
    partial class ControlImport
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
            labelImportLabel = new Label();
            buttonImport = new Button();
            buttonSelectFile = new Button();
            openFileDialogMain = new OpenFileDialog();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(labelImportLabel);
            panelMain.Controls.Add(buttonImport);
            panelMain.Controls.Add(buttonSelectFile);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(481, 358);
            panelMain.TabIndex = 0;
            // 
            // labelImportLabel
            // 
            labelImportLabel.AutoSize = true;
            labelImportLabel.Location = new Point(52, 73);
            labelImportLabel.Name = "labelImportLabel";
            labelImportLabel.Size = new Size(154, 15);
            labelImportLabel.TabIndex = 2;
            labelImportLabel.Text = "Trwa import proszę czekać...";
            labelImportLabel.Visible = false;
            // 
            // buttonImport
            // 
            buttonImport.Location = new Point(136, 30);
            buttonImport.Name = "buttonImport";
            buttonImport.Size = new Size(100, 25);
            buttonImport.TabIndex = 1;
            buttonImport.Text = "Importuj";
            buttonImport.UseVisualStyleBackColor = true;
            buttonImport.Click += buttonImport_Click;
            // 
            // buttonSelectFile
            // 
            buttonSelectFile.Location = new Point(30, 30);
            buttonSelectFile.Name = "buttonSelectFile";
            buttonSelectFile.Size = new Size(100, 25);
            buttonSelectFile.TabIndex = 0;
            buttonSelectFile.Text = "Wybierz plik";
            buttonSelectFile.UseVisualStyleBackColor = true;
            buttonSelectFile.Click += buttonSelectFile_Click;
            // 
            // ControlImport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Name = "ControlImport";
            Size = new Size(481, 358);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private OpenFileDialog openFileDialogMain;
        private Button buttonSelectFile;
        private Button buttonImport;
        private Label labelImportLabel;
    }
}
