using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WristStrapControlApp.DAL.Entities
{
    public class MonitorDevice
    {
        [Key]
        public int MonitorId { get; set; }
        public string MonitorName { get; set; } = string.Empty; // Monitor Main Line, Monitor Sub Line
        public int LineId { get; set; }
        public string? IpAddress { get; set; }
        public AlarmStatus AlarmStatus { get; set; } = AlarmStatus.OFF; // Trạng thái còi đỏ (On/Off)
        public DateTime? LastAlarmTime { get; set; }

        // Navigation Properties
        public virtual ProductionLine Line { get; set; } = null!;
        public virtual ICollection<AlarmLog> AlarmLogs { get; set; } = new List<AlarmLog>();
    }
}
