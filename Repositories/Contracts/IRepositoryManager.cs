﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        ICategoryRepository CategoryRepository { get; }
        IBookRepository Book { get; }
        Task SaveAsync();
    }
}
