using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace WristStrapControlApp.DAL.Entities
{
    public class ProductionLine
    {
        [Key]
        public int LineId { get; set; }
        public string LineCode { get; set; } = string.Empty; // MAIN_LINE, SUB_LINE
        public string LineName { get; set; } = string.Empty; // Line Main, Line Sub
        public LineType LineType { get; set; }
        public int TotalStations { get; set; } // 50 hoặc 38
        public string? Description { get; set; }

        // Navigation Properties
        public virtual ICollection<Station> Stations { get; set; } = new List<Station>();
        public virtual ICollection<MonitorDevice> MonitorDevices { get; set; } = new List<MonitorDevice>();
    }
}
