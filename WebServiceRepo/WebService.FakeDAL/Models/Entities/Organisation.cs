using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.FakeDAL.Models.Interfaces;

namespace WebService.FakeDAL.Models.Entities
{
    /// <summary>
    /// Модель организации
    /// </summary>
    public class Organisation : IOrganisation
    {
        private string _name;
        private long _taxId;
        private long _registrationReasonCode;

        public string Name { get => _name; set => _name = value; }
        public long TaxId { get => _taxId; set => _taxId = value; }
        public long RegistrationReasonCode { get => _registrationReasonCode; set => _registrationReasonCode = value; }

    }
}
