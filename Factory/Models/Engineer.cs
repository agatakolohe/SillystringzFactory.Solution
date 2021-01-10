using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
    public class Engineer
    {
        public Engineer()
        {
            this.Machines = new HashSet<EngineerMachine>();
        }

        public int EngineerId { get; set; }
        public string EngineerName { get; set; }
        public string EngineerStatus { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime LicenseRenewalDate { get; set; }
        public virtual ICollection<EngineerMachine> Machines { get; set; }
    }
}