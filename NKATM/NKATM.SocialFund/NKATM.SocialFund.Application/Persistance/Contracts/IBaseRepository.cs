﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NKATM.SocialFund.Application.Persistance.Contracts
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> GetAsync(Guid id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
