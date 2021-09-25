using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.FakeDAL.Models.Entities;
using WebService.FakeDAL.Models.Interfaces;
using WebService.FakeDAL.Repository.Interfaces;

namespace WebService.FakeDAL.Repository.Entities
{
    public class OrganisationRepository : IRepository<IOrganisation>
    {
        /// <summary>
        /// Фейковый список БД
        /// </summary>
        private List<IOrganisation> _context; // ToDo - переделать на другую коллекцию, 
                                             //не позволяющую добавлять объекты с одинаковыми данными
        public OrganisationRepository()
        {
            _context = GetFakeContext();
        }

        private List<IOrganisation> GetFakeContext()
        {
            return new List<IOrganisation>
            {
                new Organisation 
                {
                    Name = "ООО \"Славянка\"",
                    TaxId = 7736624353,
                    RegistrationReasonCode = 770301001,
                },

                new Organisation
                {
                    Name = "ИП Тышлангян Александра Владимировна",
                    TaxId = 7713716199,
                    RegistrationReasonCode = 770301001,
                },

                new Organisation
                {
                    Name = "ООО \"ОптТорг\"",
                    TaxId = 7729742081,
                    RegistrationReasonCode = 770301001,
                },
            };
        }

        public void Create(IOrganisation organisation)
        {
            _context.Add(organisation);
        }


        public IEnumerable<IOrganisation> GetAll()
        {
            return _context;
        }

        public void Update(IOrganisation organisation)
        {
            var existingOrganisation = _context.FirstOrDefault(x => x.TaxId == organisation.TaxId);
            if (existingOrganisation == null) { return; }

            _context[_context.IndexOf(existingOrganisation)] = organisation;
        }

        public IOrganisation Read(int taxId)
        {
            return _context.FirstOrDefault(organisation => organisation.TaxId == taxId);
        }

        public void Delete(IOrganisation organisation)
        {
            if (_context.Any(x => x == organisation))
            {
                _context.Remove(organisation);
            }
        }
    }
}
