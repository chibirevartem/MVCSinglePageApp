using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Models.Interfaces;

namespace WebService.Models.Entities
{
    /// <summary>
    /// Модель организации
    /// </summary>
    public class Organisation : IOrganisation
    {
        private string _name;
        private string _taxId;
        private string _registrationReasonCode;

        public string Name { get => _name; set => _name = value; }
        public string TaxId { get => _taxId; set => _taxId = value; }
        public string RegistrationReasonCode { get => _registrationReasonCode; set => _registrationReasonCode = value; }
    }

}