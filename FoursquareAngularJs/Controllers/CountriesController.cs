using FoursquareAngularJs.Data;
using FoursquareAngularJs.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoursquareAngularJs.Controllers
{
    public class CountriesController : BaseApiController
    {

        public CountriesController()
        {

        }
       
        private readonly ICountriesRepository countriesRepository;

        public CountriesController(ICountriesRepository _countriesRepository)
        {
            countriesRepository= _countriesRepository;
        }

        [HttpGet]
        public IEnumerable<Countries> Get( int page = 0, int pageSize = 10)
        {
            IQueryable<Countries> query;

            query = countriesRepository.Get().OrderByDescending(b => b.Id);

            var totalCount = query.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
            var paginationHeader = new
            {
                TotalCount = totalCount,
                TotalPages = totalPages,
            };

            System.Web.HttpContext.Current.Response.Headers.Add("X-Pagination",
                                                                Newtonsoft.Json.JsonConvert.SerializeObject(paginationHeader));

            var results = query
                         .Skip(pageSize * page)
                         .Take(pageSize)
                         .ToList();


            return results;

        }
    }
}
