using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.FakeDAL.Models.Interfaces;

namespace WebService.FakeDAL.Repository.Interfaces
{
    public interface IRepository<T>
        where T : IOrganisation
    {
        void Create(T organisation);
        T Read(int taxId);
        void Update(T organisation);
        void Delete(T organisation);
        
        IEnumerable<T> GetAll();
    }
}
