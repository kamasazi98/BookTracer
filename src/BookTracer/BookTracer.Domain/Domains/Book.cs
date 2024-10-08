﻿using BookTracer.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer.Domain.Domains
{
    public class Book : IBook
    {
        private IAuthor? author;
        private readonly IAuthorRepository authorRepository;

        public Book(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
            Name = string.Empty;
        }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Guid AuthorId { get; private set; }
        public int Rate { get; private set; }
        public IAuthor Author
        {
            get => author == null ? author = authorRepository.Retrieve(AuthorId) : author;
            private set => author = value;
        }
        public Book New(string name, Guid authorId, int rate)
        {
            Name = name;
            AuthorId = authorId;
            Rate = rate;
            return this;
        }
        public Book Load(string id, string name, string authorId, int rate)
        {
            Id = Guid.Parse(id);
            Name = name;
            AuthorId = Guid.Parse(authorId);
            Rate = rate;
            return this;
        }
        public void SetId(Guid id)
        {
            Id = id;
        }
    }

    public interface IBook
    {
        Guid Id { get; }
        string Name { get; }
        Guid AuthorId { get; }
        IAuthor Author { get; }
        int Rate { get; }

        Book New(string name, Guid authorId, int rate);
        void SetId(Guid id);
    }
}
