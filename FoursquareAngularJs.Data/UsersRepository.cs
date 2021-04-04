using FoursquareAngularJs.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoursquareAngularJs.Data
{

    public interface IUsersRepository
    {
        IQueryable<User> Get();

        User Creat(User user);

       // int SavePlace(BookmarkedPlace bookmarkedPlace);
    }
    public class UsersRepository : IUsersRepository
    {
        private FourSquareContext _ctx;
        public UsersRepository()
        {
            _ctx = new FourSquareContext();
        }

        public User Creat(User user)
        {
            _ctx.Users.Add(user);
            _ctx.SaveChanges();
            return user;
        }

        public IQueryable<User> Get()
        {
            return _ctx.Users.AsQueryable();
        }
    }
}
