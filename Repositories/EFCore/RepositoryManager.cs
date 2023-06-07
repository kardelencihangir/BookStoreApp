using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly Lazy<IBookRepository> _bookRepository;
        private readonly Lazy<ICategoryRepository> _categoryRepository;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _bookRepository = new Lazy<IBookRepository>(() => new BookRepository(_context));
            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(_context));
        }

        public IBookRepository Book => _bookRepository.Value;

        public ICategoryRepository CategoryRepository => _categoryRepository.Value;

        // Bir class içerisinde başka bir class new'lememeliyiz, bağımlı olmaması için.
        // IoC ile çözebilirdik fakat şimdilik pratik olması için yaptık.

        public async Task SaveAsync()
        {            
            await _context.SaveChangesAsync();
        }
    }
}
