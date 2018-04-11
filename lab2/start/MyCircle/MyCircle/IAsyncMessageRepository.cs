﻿using System.Collections.Generic;
using System.Threading.Tasks;
using MyCircle.Services;

namespace MyCircle
{
    public interface IAsyncMessageRepository
    {
        Task AddAsync(CircleMessage message);
        Task<IEnumerable<CircleMessage>> GetRootsAsync(int count);
        Task<int> GetDetailCountAsync(string id);
        Task<IEnumerable<CircleMessage>> GetDetailsAsync(string id);
    }
}