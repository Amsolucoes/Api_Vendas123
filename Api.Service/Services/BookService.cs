using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Book;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Services
{
    public class BookService : IBookServices
    {
        private IBookRepository<BookEntity> _repository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository<BookEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BookEntity>> SearchAuthor(string author)
        {
            return await _repository.SearchAuthor(author);
        }

        public async Task<BookEntity> SearchName(string book)
        {
            return await _repository.SearchNmae(book);
        }
    }
}
