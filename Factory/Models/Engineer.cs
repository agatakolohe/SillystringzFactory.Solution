using System.Collections.Generic;

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

        public virtual ICollection<EngineerMachine> Machines { get; set; }

    }
}