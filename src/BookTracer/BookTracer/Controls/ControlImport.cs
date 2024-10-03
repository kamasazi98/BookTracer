using BookTracer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookTracer.Controls
{
    public partial class ControlImport : UserControl
    {
        private string filePath = string.Empty;
        private readonly IImportService importService;

        public ControlImport(IImportService importService)
        {
            InitializeComponent();
            this.importService = importService;
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
                filePath = openFileDialogMain.FileName;
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
                MessageBox.Show($"Plik nie istnieje w podanej ścieżce [{filePath}].", "Nieprawidłowa ścieżka", MessageBoxButtons.OK, MessageBoxIcon.Error);

            try
            {
                labelImportLabel.Text = "Trwa import proszę czekać...";
                labelImportLabel.Visible = true;

                importService.Import(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Podczas importu wystąpił błąd. {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                labelImportLabel.Text = "Zakończono import";
            }
        }
    }
}
