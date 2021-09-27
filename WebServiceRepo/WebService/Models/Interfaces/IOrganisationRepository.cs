using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.Models.Entities;

namespace WebService.Models.Interfaces
{
    public interface IOrganisationRepository<T>
        where T : Organisation
    {
        void Create(T organisation);
        T Read(string taxId);
        void Update(T organisation);
        void Delete(string taxId);

        IEnumerable<T> GetAll();
    }
}
