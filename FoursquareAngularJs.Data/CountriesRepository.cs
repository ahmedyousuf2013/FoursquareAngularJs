using FoursquareAngularJs.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareAngularJs.Data
{

    public interface ICountriesRepository
    {
        IQueryable<Countries> Get();


    }
    public class CountriesRepository : ICountriesRepository
    {
        private FourSquareContext _ctx;
        public CountriesRepository()
        {

            _ctx = new FourSquareContext();
        }
        public IQueryable<Countries> Get()
        {
           return _ctx.Countries.AsQueryable();
        }
    }
}
