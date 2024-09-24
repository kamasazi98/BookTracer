using BookTracer.Domain.Repositories;
using BookTracer.Events;
using BookTracer.ViewModels;
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
    public partial class ControlAddBook : UserControl
    {
        private readonly IServiceProvider serviceProvider;

        public AddBookViewModel Context { get; set; }
        public ControlAddBook(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.serviceProvider = serviceProvider;
            Context = new AddBookViewModel();
        }
        public void InitializeControls()
        {
            pictureBoxFirstStar.Click += (sender, e) => Context.OnRateBoxClick(new RateBoxClickEvent(RateBox.First, sender));
            pictureBoxSecondStar.Click += (sender, e) => Context.OnRateBoxClick(new RateBoxClickEvent(RateBox.Second, sender));
            pictureBoxThridStar.Click += (sender, e) => Context.OnRateBoxClick(new RateBoxClickEvent(RateBox.Third, sender));
            pictureBoxFourthStar.Click += (sender, e) => Context.OnRateBoxClick(new RateBoxClickEvent(RateBox.Fourth, sender));
            pictureBoxFifthStar.Click += (sender, e) => Context.OnRateBoxClick(new RateBoxClickEvent(RateBox.Fifth, sender));

            radioButtonNewAuthor.Click += (sender, e) => Context.OnRadioAuthorExistenceClick(new RadioAuthorClickEvent(AuthorExistence.New));
            radioButtonExistingAuthor.Click += (sender, e) => Context.OnRadioAuthorExistenceClick(new RadioAuthorClickEvent(AuthorExistence.Exists));

            textBoxAuthorFirstName.DataBindings.Add(nameof(textBoxAuthorFirstName.Text), Context, nameof(Context.AuthorFirstName));
            textBoxAuthorLastName.DataBindings.Add(nameof(textBoxAuthorLastName.Text), Context, nameof(Context.AuthorLastName));
            textBoxBookName.DataBindings.Add(nameof(textBoxBookName.Text), Context, nameof(Context.BookName));

            textBoxAuthorFirstName.DataBindings.Add(nameof(textBoxAuthorFirstName.Enabled), Context, nameof(Context.IsNewAuthor));
            textBoxAuthorLastName.DataBindings.Add(nameof(textBoxAuthorLastName.Enabled), Context, nameof(Context.IsNewAuthor));
            comboBoxExistingAuthor.DataBindings.Add(nameof(comboBoxExistingAuthor.Enabled), Context, nameof(Context.IsExistingAuthor));
        }
    }
}
