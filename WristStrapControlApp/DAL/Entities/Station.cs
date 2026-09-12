using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WristStrapControlApp.DAL.Entities
{
    public class Station
    {
        [Key]
        public int StationId { get; set; }
        public int LineId { get; set; }
        public string StationCode { get; set; } = string.Empty; // M1.1, S3.1, Bending...
        public string StationName { get; set; } = string.Empty;
        public int DisplayOrder { get; set; } // Thứ tự sắp xếp trên màn hình Monitor
        public string? IpAddress { get; set; } // IP của ESD Hardware Checker tại trạm
        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public virtual ProductionLine Line { get; set; } = null!;
        public virtual CurrentStationStatus? CurrentStatus { get; set; }
        public virtual ICollection<WristStrapLog> WristStrapLogs { get; set; } = new List<WristStrapLog>();
    }
}
