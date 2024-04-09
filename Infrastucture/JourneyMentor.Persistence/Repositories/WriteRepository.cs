using JourneyMentor.Application.Interfaces.Repositories;
using JourneyMentor.Domain.Common;
using JourneyMentor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JourneyMentor.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class, IEntityBase, new()
    {
        private readonly DbContext dbContext;
        private readonly HttpClient _httpClient;


        public WriteRepository(DbContext dbContext, HttpClient httpClient)
        {
            this.dbContext = dbContext;
            this._httpClient = httpClient;
        }
        private DbSet<T> Table { get => dbContext.Set<T>(); }


        public async Task ImportGenericAviationStackDataAsync(List<T> dataList)
        {
            Table.AddRange(dataList);
            await dbContext.SaveChangesAsync();
        }

        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task AddRangeAsync(IList<T> entities)
        {
            await Table.AddRangeAsync(entities);
        }
        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
            return entity;
        }
        public async Task HardDeleteAsync(T entity)
        {
            await Task.Run(() => Table.Remove(entity));
        }

        public async Task SoftDeleteAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
        }

        public async Task HardDeleteRangeAsync(IList<T> entity)
        {
            await Task.Run(() => Table.RemoveRange(entity));
        }
    }
}