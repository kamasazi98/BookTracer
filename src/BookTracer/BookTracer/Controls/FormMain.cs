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
        public UserControl? ActiveMainControl { get; set; }

        private void buttonBookList_Click(object sender, EventArgs e)
        {
            ActiveMainControl = serviceProvider.GetRequiredService<ControlBookList>();
            panelForControls.Controls.Clear();
            panelForControls.Controls.Add(ActiveMainControl);
        }

        private void buttonAuthorList_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            ActiveMainControl = serviceProvider.GetRequiredService<ControlAddBook>();
            panelForControls.Controls.Clear();
            panelForControls.Controls.Add(ActiveMainControl);
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            ActiveMainControl = serviceProvider.GetRequiredService<ControlImport>();
            panelForControls.Controls.Clear();
            panelForControls.Controls.Add(ActiveMainControl);
        }
    }
}
