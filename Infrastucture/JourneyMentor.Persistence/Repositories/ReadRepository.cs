using JourneyMentor.Application.Interfaces.Repositories;
using JourneyMentor.Domain.Common;
using JourneyMentor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JourneyMentor.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class, IEntityBase, new()
    {
        private readonly DbContext dbContext;
        private readonly HttpClient _httpClient;


        public ReadRepository(DbContext dbContext, HttpClient httpClient)
        {
            this.dbContext = dbContext;
            this._httpClient = httpClient;
        }

        private DbSet<T> Table { get => dbContext.Set<T>(); }

        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false)
        {
            IQueryable<T> queryable = Table;
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include is not null) queryable = include(queryable);
            if (predicate is not null) queryable = queryable.Where(predicate);
            if (orderBy is not null)
                return await orderBy(queryable).ToListAsync();

            return await queryable.ToListAsync();
        }

        public async Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false, int currentPage = 1, int pageSize = 3)
        {
            IQueryable<T> queryable = Table;
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include is not null) queryable = include(queryable);
            if (predicate is not null) queryable = queryable.Where(predicate);
            if (orderBy is not null)
                return await orderBy(queryable).Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();

            return await queryable.Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false)
        {
            IQueryable<T> queryable = Table;
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include is not null) queryable = include(queryable);

            //queryable.Where(predicate);

            return await queryable.FirstOrDefaultAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            Table.AsNoTracking();
            if (predicate is not null) Table.Where(predicate);

            return await Table.CountAsync();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false)
        {
            if (!enableTracking) Table.AsNoTracking();
            return Table.Where(predicate);
        }


        public async Task<IList<T>> GetAllDataFromAvitionStackAsyn(string apiUrl, string accessKey)
        {
            List<Flight> allFlights = new List<Flight>();
            int offset = 0;
            int limit = 100;

            while (true)
            {
                string requestUrl = $"{apiUrl}?access_key={accessKey}&offset={offset}&limit={limit}";

                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
                //if (response.IsSuccessStatusCode)
                //{
                //    string responseBody = await response.Content.ReadAsStringAsync();
                //    var responseModel = JsonConvert.DeserializeObject<T>(responseBody);
                //    var flightsData = responseModel.Data;

                //    foreach (var flightData in flightsData)
                //    {
                //        var flight = MapToFlight(flightData);
                //        allFlights.Add(flight);
                //    }


                //    var total = responseModel.Pagination.Total;
                //    offset += limit;
                //    if (offset >= total)
                //    {
                //        break;
                //    }
                //}
                //else
                //{
                //    throw new Exception($"Failed to get data. Status code: {response.StatusCode}");
                //}
            }

           // return allFlights;
            return default;

        }
    }
}
