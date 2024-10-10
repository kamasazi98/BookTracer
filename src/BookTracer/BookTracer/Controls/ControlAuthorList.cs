using BookTracer.Domain.Repositories;
using BookTracer.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zuby.ADGV;

namespace BookTracer.Controls
{
    public partial class ControlAuthorList : UserControl
    {
        private AuthorListViewModel context;
        private readonly IServiceProvider serviceProvider;

        public ControlAuthorList(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.serviceProvider = serviceProvider;
            context = new AuthorListViewModel(serviceProvider.GetRequiredService<IAuthorRepository>()).Initialize();
            InitializeBinding();
        }
        private void InitializeBinding()
        {
            advancedDataGridViewAuthors.DataSource = context.AuthorsDataSource;
            foreach (DataGridViewColumn column in advancedDataGridViewAuthors.Columns)
            {
                switch (column.Name)
                {
                    case nameof(AuthorListElementViewModel.No):
                        column.HeaderText = "Lp.";
                        break;
                    case nameof(AuthorListElementViewModel.Id):
                        column.Visible = false;
                        break;
                    case nameof(AuthorListElementViewModel.Domain):
                        column.Visible = false;
                        break;
                    case nameof(AuthorListElementViewModel.FirstName):
                        column.HeaderText = "Imię autora";
                        break;
                    case nameof(AuthorListElementViewModel.LastName):
                        column.HeaderText = "Nazwisko autora";
                        break;
                }
                advancedDataGridViewAuthors.SetFilterAndSortEnabled(column, true);
            }
            advancedDataGridViewAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            advancedDataGridViewAuthors.SelectionChanged += AdvancedDataGridViewAuthors_SelectionChanged;

            advancedDataGridViewAuthorBooks.DataSource = context.AuthorBooksDataSource;
            foreach (DataGridViewColumn column in advancedDataGridViewAuthorBooks.Columns)
            {
                switch (column.Name)
                {
                    case nameof(BookElementViewModel.No):
                        column.HeaderText = "Lp.";
                        break;
                    case nameof(BookElementViewModel.BookName):
                        column.HeaderText = "Nazwa książki";
                        break;
                    case nameof(BookElementViewModel.BookRating):
                        column.HeaderText = "Ocena";
                        break;
                }
                advancedDataGridViewAuthorBooks.SetFilterAndSortEnabled(column, true);
            }
            advancedDataGridViewAuthorBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AdvancedDataGridViewAuthors_SelectionChanged(object? sender, EventArgs e)
        {
            if (sender is not AdvancedDataGridView authorsDataGridView)
                return;
            if (authorsDataGridView.CurrentRow == null)
                return;

            var id = Convert.ToString(authorsDataGridView.CurrentRow.Cells[nameof(AuthorListElementViewModel.Id)].Value) ?? string.Empty;
            context.FocusedAuthorChanged(Guid.Parse(id));
        }
    }
}
