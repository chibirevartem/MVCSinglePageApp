using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceRepo.Common.Models.Interfaces
{
    public interface IRepository<T>
        where T : Organisation
    {
        void Create(T organisation);
        T Read(string taxId);
        void Update(T organisation);
        void Delete(string taxId);

        IEnumerable<T> GetAll();
    }
}
