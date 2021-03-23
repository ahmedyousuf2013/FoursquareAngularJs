using FoursquareAngularJs.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareAngularJs.Data
{

    public interface ICountriesRepository
    {
        IQueryable<Countries> Get();
        Countries Insert(Countries countries);
        Countries Update(Countries countries);
        Countries Delete (int id);


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

        public Countries Insert(Countries countries)
        {
            _ctx.Countries.Add(countries);
            _ctx.SaveChanges();
            return countries;
        }

        public Countries Update(Countries countries)
        {
            _ctx.Entry(countries).State = EntityState.Modified;
            _ctx.SaveChanges();

            return countries;
        }

        public Countries Delete(int id)
        {

            var countries= _ctx.Countries.Find(id);
            _ctx.Countries.Remove(countries);
            _ctx.SaveChanges();
            return countries;
        }
    }
}
