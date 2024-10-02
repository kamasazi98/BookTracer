using Microsoft.Extensions.DependencyInjection;

namespace BookTracer.Controls
{
    public partial class FormMain : Form
    {
        private readonly IServiceProvider serviceProvider;

        public FormMain(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.serviceProvider = serviceProvider;
        }
        public UserControl ActiveControl { get; set; }

        private void buttonBookList_Click(object sender, EventArgs e)
        {
            panelForControls.Controls.Clear();
        }

        private void buttonAuthorList_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            ActiveControl = serviceProvider.GetRequiredService<ControlAddBook>();
            panelForControls.Controls.Clear();
            panelForControls.Controls.Add(ActiveControl);
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {

        }
    }
}
