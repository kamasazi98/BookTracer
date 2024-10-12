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
    public partial class ControlBookList : UserControl
    {
        private BookListViewModel context;
        private readonly IServiceProvider serviceProvider;
        private Dictionary<string, bool> sortDirections;
        public ControlBookList(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            context = new BookListViewModel(serviceProvider.GetRequiredService<IBookRepository>()).Initialize();
            sortDirections = new Dictionary<string, bool>();
            this.serviceProvider = serviceProvider;
            InitializeBinding();
        }
        private void InitializeBinding()
        {
            advancedDataGridView.FilterAndSortEnabled = true;
            advancedDataGridView.AutoGenerateColumns = true;
            advancedDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            advancedDataGridView.AllowUserToAddRows = false;

            advancedDataGridView.DataSource = new DataView(context.BooksDataTable);
            foreach (DataGridViewColumn column in advancedDataGridView.Columns)
            {
                switch (column.Name)
                {
                    case nameof(BookListElementViewModel.No):
                        column.HeaderText = "Lp.";
                        break;
                    case nameof(BookListElementViewModel.BookName):
                        column.HeaderText = "Nazwa książki";
                        break;
                    case nameof(BookListElementViewModel.BookRating):
                        column.HeaderText = "Ocena";
                        break;
                    case nameof(BookListElementViewModel.AuthorFirstName):
                        column.HeaderText = "Imię autora";
                        break;
                    case nameof(BookListElementViewModel.AuthorLastName):
                        column.HeaderText = "Nazwisko autora";
                        break;
                }
                advancedDataGridView.SetFilterAndSortEnabled(column, true);
            }
        }
    }
}
