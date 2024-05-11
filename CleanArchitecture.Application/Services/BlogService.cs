using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    internal class BlogService : IBlogService
    {
        public Task<Blog> CreateAsync(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
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

        public Task<int> UpdateAsync(int id, Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
