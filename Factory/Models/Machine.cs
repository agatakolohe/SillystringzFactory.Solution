using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Machine
    {
        public Machine()
        {
            this.Engineers = new HashSet<EngineerMachine>();
        }

        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public string MachineDescription { get; set; }
        public string MachineStatus { get; set; }
        public ICollection<EngineerMachine> Engineers { get; }

    }
}