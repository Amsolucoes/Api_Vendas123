using Api.Data.Context;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BookRepository<T> : IBookRepository<T> where T : BookEntity
    {
        protected readonly MyContext _context;
        private DbSet<T> _dataset;
        public BookRepository(MyContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> SearchAuthor(string author)
        {
            try
            {
                return await _dataset.Where(b => b.specifications.Author == author).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<T> SearchNmae(string name)
        {
            try
            {
                return await _dataset.FirstOrDefaultAsync(b => b.Name== name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
