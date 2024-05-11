using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interface
{
<<<<<<< HEAD
    public interface IBlogRepository
=======
    internal interface IBlogRepository
>>>>>>> b38b5c5ac4e1d307fc303e6288b68252f909c817
    {
        Task<List<Blog>> GetAllAsync();
        Task<Blog> GetByIdAsync(int id);
        Task<Blog> CreateAsync(Blog blog);
        Task<Blog> UpdateAsync(int id, Blog blog);
        Task<Blog> DeleteAsync(int id);
    }
}
