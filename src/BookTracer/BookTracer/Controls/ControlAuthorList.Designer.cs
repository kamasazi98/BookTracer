namespace BookTracer.Controls
{
    partial class ControlAuthorList
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
            splitContainerMain = new SplitContainer();
            advancedDataGridViewAuthors = new Zuby.ADGV.AdvancedDataGridView();
            advancedDataGridViewAuthorBooks = new Zuby.ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridViewAuthors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridViewAuthorBooks).BeginInit();
            SuspendLayout();
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.Location = new Point(0, 0);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(advancedDataGridViewAuthors);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(advancedDataGridViewAuthorBooks);
            splitContainerMain.Size = new Size(1150, 629);
            splitContainerMain.SplitterDistance = 566;
            splitContainerMain.TabIndex = 0;
            // 
            // advancedDataGridViewAuthors
            // 
            advancedDataGridViewAuthors.BackgroundColor = SystemColors.ButtonFace;
            advancedDataGridViewAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridViewAuthors.Dock = DockStyle.Fill;
            advancedDataGridViewAuthors.FilterAndSortEnabled = true;
            advancedDataGridViewAuthors.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridViewAuthors.GridColor = SystemColors.Menu;
            advancedDataGridViewAuthors.Location = new Point(0, 0);
            advancedDataGridViewAuthors.MaxFilterButtonImageHeight = 23;
            advancedDataGridViewAuthors.Name = "advancedDataGridViewAuthors";
            advancedDataGridViewAuthors.RightToLeft = RightToLeft.No;
            advancedDataGridViewAuthors.Size = new Size(566, 629);
            advancedDataGridViewAuthors.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridViewAuthors.TabIndex = 0;
            // 
            // advancedDataGridViewAuthorBooks
            // 
            advancedDataGridViewAuthorBooks.BackgroundColor = SystemColors.ButtonFace;
            advancedDataGridViewAuthorBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridViewAuthorBooks.Dock = DockStyle.Fill;
            advancedDataGridViewAuthorBooks.FilterAndSortEnabled = true;
            advancedDataGridViewAuthorBooks.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridViewAuthorBooks.GridColor = SystemColors.Menu;
            advancedDataGridViewAuthorBooks.Location = new Point(0, 0);
            advancedDataGridViewAuthorBooks.MaxFilterButtonImageHeight = 23;
            advancedDataGridViewAuthorBooks.Name = "advancedDataGridViewAuthorBooks";
            advancedDataGridViewAuthorBooks.RightToLeft = RightToLeft.No;
            advancedDataGridViewAuthorBooks.Size = new Size(580, 629);
            advancedDataGridViewAuthorBooks.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridViewAuthorBooks.TabIndex = 0;
            // 
            // ControlAuthorList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainerMain);
            Name = "ControlAuthorList";
            Size = new Size(1150, 629);
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)advancedDataGridViewAuthors).EndInit();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridViewAuthorBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainerMain;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridViewAuthors;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridViewAuthorBooks;
    }
}
