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
            InitializeControls();
        }
        public void InitializeControls()
        {
            pictureBoxFirstStar.Click += (sender, e) => Context.OnRateBoxClick(new RateBoxClickEvent(RateBox.First, new List<PictureBox>() { pictureBoxFirstStar, pictureBoxSecondStar, pictureBoxThridStar, pictureBoxFourthStar, pictureBoxFifthStar }));
            pictureBoxSecondStar.Click += (sender, e) => Context.OnRateBoxClick(new RateBoxClickEvent(RateBox.Second, new List<PictureBox>() { pictureBoxFirstStar, pictureBoxSecondStar, pictureBoxThridStar, pictureBoxFourthStar, pictureBoxFifthStar }));
            pictureBoxThridStar.Click += (sender, e) => Context.OnRateBoxClick(new RateBoxClickEvent(RateBox.Third, new List<PictureBox>() { pictureBoxFirstStar, pictureBoxSecondStar, pictureBoxThridStar, pictureBoxFourthStar, pictureBoxFifthStar }));
            pictureBoxFourthStar.Click += (sender, e) => Context.OnRateBoxClick(new RateBoxClickEvent(RateBox.Fourth, new List<PictureBox>() { pictureBoxFirstStar, pictureBoxSecondStar, pictureBoxThridStar, pictureBoxFourthStar, pictureBoxFifthStar }));
            pictureBoxFifthStar.Click += (sender, e) => Context.OnRateBoxClick(new RateBoxClickEvent(RateBox.Fifth, new List<PictureBox>() { pictureBoxFirstStar, pictureBoxSecondStar, pictureBoxThridStar, pictureBoxFourthStar, pictureBoxFifthStar }));
            buttonAdd.Click += (sender, e) => Context.OnAdd();

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
