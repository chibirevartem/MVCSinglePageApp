using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebService.Models.Entities;
using WebService.Models.Interfaces;

namespace WebService.Controllers
{
    public class WebController : ApiController
    {
        private IOrganisationRepository<Organisation> _organisationRepository = new FakeDbOrganisationRepository();

        public IEnumerable<Organisation> GetAllOrganisations() 
        {
            return _organisationRepository.GetAll();
        }

        public Organisation GetOrganisation(string taxId) 
        {
            return _organisationRepository.Read(taxId);
        }

        [HttpPost]
        public void PostOrganisation(Organisation organisation) 
        {
            _organisationRepository.Create(organisation);
        }

        [HttpPut]
        public void PutOrganisation(Organisation organisation) 
        {
            _organisationRepository.Update(organisation);
        }

        public void DeleteOrganisation(string taxId) 
        {
            _organisationRepository.Delete(taxId);
        }
    }
}