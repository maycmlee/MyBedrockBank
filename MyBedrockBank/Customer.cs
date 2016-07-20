using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBedrockBank
{

    /// <summary>
    /// This class defines a customer
    /// </summary>
    public class Customer
    {
        #region Properties
        /// <summary>
        /// Customer Id
        /// </summary>

        //[Key] is an attribute to the instance member below
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string Address { get; set; }

        #endregion
    }
}
