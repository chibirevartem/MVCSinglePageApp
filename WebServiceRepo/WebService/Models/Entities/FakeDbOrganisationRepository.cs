using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Models.Entities
{
    public class FakeDbOrganisationRepository : OrganisationRepository
    {
        public override List<Organisation> GetContext()
        {
            return new List<Organisation>
            {
                new Organisation
                {
                    Name = "ООО \"Славянка\"",
                    TaxId = "7736624353",
                    RegistrationReasonCode = "770301001",
                },

                new Organisation
                {
                    Name = "ИП Тышлангян Александра Владимировна",
                    TaxId = "7713716199",
                    RegistrationReasonCode = "770301001",
                },

                new Organisation
                {
                    Name = "ООО \"ОптТорг\"",
                    TaxId = "7729742081",
                    RegistrationReasonCode = "770301001",
                },
            };
        }
    }
}