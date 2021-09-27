using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService.Models.Interfaces
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
        string TaxId { get; set; }
        /// <summary>
        /// КПП
        /// </summary>
        string RegistrationReasonCode { get; set; }
    }
}
