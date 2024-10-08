namespace BookTracer.Controls
{
    partial class ControlBookList
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
            advancedDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView).BeginInit();
            SuspendLayout();
            // 
            // advancedDataGridView
            // 
            advancedDataGridView.BackgroundColor = SystemColors.ButtonFace;
            advancedDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridView.Dock = DockStyle.Fill;
            advancedDataGridView.FilterAndSortEnabled = true;
            advancedDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView.GridColor = SystemColors.Menu;
            advancedDataGridView.Location = new Point(0, 0);
            advancedDataGridView.MaxFilterButtonImageHeight = 23;
            advancedDataGridView.Name = "advancedDataGridView";
            advancedDataGridView.RightToLeft = RightToLeft.No;
            advancedDataGridView.Size = new Size(660, 367);
            advancedDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView.TabIndex = 0;
            // 
            // ControlBookList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(advancedDataGridView);
            Name = "ControlBookList";
            Size = new Size(660, 367);
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView;
    }
}
