using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceRepo.Common.Models.Entities;
using WebServiceRepo.Common.Models.Interfaces;

namespace WebServiceRepo
{
    public abstract class OrganisationRepository : IRepository<Organisation>
    {
        private List<Organisation> _context;
        public OrganisationRepository()
        {
            _context = GetContext();
        }

        public abstract List<Organisation> GetContext();

        public void Create(Organisation organisation)
        {
            _context.Add(organisation);
        }


        public IEnumerable<Organisation> GetAll()
        {
            return _context;
        }

        public void Update(Organisation organisation)
        {
            var existingOrganisation = _context.FirstOrDefault(x => x.TaxId == organisation.TaxId);
            if (existingOrganisation == null) { return; }

            _context[_context.IndexOf(existingOrganisation)] = organisation;
        }

        public Organisation Read(string taxId)
        {
            return _context.FirstOrDefault(organisation => organisation.TaxId == taxId);
        }

        public void Delete(string taxId)
        {
            var organisationToDelete = _context.FirstOrDefault(organisation => organisation.TaxId == taxId);
            if (organisationToDelete != null)
            {
                _context.Remove(organisationToDelete);
            }
        }
    }
}
