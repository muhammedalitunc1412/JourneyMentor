using JourneyMentor.Application.Interfaces.AutoMapper;
using JourneyMentor.Application.Interfaces.Repositories;
using JourneyMentor.Application.Interfaces.UnitOfWorks;
using JourneyMentor.Persistence.Context;
using JourneyMentor.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JourneyMentor.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;
        private readonly HttpClient _httpClient;
        private readonly IMapper mapper;


        public UnitOfWork(AppDbContext dbContext, IHttpClientFactory httpClientFactory, IMapper mapper)
        {
            this.dbContext = dbContext;
            this._httpClient = httpClientFactory.CreateClient();
            this.mapper = mapper;

        }
        public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();


        public int Save() => dbContext.SaveChanges();
        public async Task<int> SaveAsync() => await dbContext.SaveChangesAsync();
        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(dbContext, _httpClient,mapper);
        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>() => new WriteRepository<T>(dbContext, _httpClient);
    }
}
