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
    public class UsersController : BaseApiController
    {
        private readonly IUsersRepository usersRepository;

        public UsersController(IUsersRepository _usersRepository)
        {
            usersRepository =_usersRepository;
        }
       
        [HttpGet]
        public IEnumerable<User> Get(int Take = 0, int pageSize = 5)
        {
            IQueryable<User> query;

            query = usersRepository.Get().OrderBy(b => b.Id);

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
                         .Skip(Take * pageSize)
                         .Take(pageSize)
                         .ToList();
            return results;

        }

        public User Create(User user)
        {
            return usersRepository.Creat(user);
        }
    }
}
