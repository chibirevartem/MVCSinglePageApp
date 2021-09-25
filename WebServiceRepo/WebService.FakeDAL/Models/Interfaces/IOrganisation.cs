using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService.FakeDAL.Models.Interfaces
{
    /// <summary>
    /// Контракт на описание организации
    /// </summary>
    public interface IOrganisation
    {
        /// <summary>
        /// Наименование
        /// </summary>  
        string Name { get; set; }
        /// <summary>
        /// ИНН
        /// </summary>
        long TaxId { get; set; }
        /// <summary>
        /// КПП
        /// </summary>
        long RegistrationReasonCode { get; set; }
    }
}
