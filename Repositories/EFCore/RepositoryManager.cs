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

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _bookRepository = new Lazy<IBookRepository>(() => new BookRepository(_context));
        }

        public IBookRepository Book => _bookRepository.Value;
        
        // Bir class içerisinde başka bir class new'lememeliyiz, bağımlı olmaması için.
        // IoC ile çözebilirdik fakat şimdilik pratik olması için yaptık.

        public async Task SaveAsync()
        {            
            await _context.SaveChangesAsync();
        }
    }
}
