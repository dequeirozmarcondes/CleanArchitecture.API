using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        public Task<Blog> CreateAsync(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Task<Blog> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Blog>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Blog> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Blog> UpdateAsync(int id, Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
