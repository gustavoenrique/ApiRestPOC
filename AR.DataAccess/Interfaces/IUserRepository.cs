using AR.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.DataAccess.Interfaces
{
    public interface IUserRepository
    {
        IQueryable<User> GetAll();
        Task Add(User entity);
    }
}
