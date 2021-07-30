using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Console.BL.Models
{
    public class Slot
    {
        public int Id { get; set; }
        public int SlotId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Constitution { get; set; }
        public string Intelligence { get; set; }
        public string Wisdon { get; set; }
        public string Charisma { get; set; }
        public string HitPoints { get; set; }
        public string ArmorClass { get; set; }
        public string Initiative { get; set; }
        public string Speed { get; set; }
        public int STSuccessCount { get; set; }
        public int STFailCount { get; set; }
        public string AdditionDetails { get; set; }
    }
}
