using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WristStrapControlApp.DAL.Entities
{
    public class AlarmLog
    {
        [Key]
        public long AlarmLogId { get; set; }
        public int MonitorId { get; set; }
        public int StationId { get; set; }
        public DateTime TriggerTime { get; set; } = DateTime.Now;
        public DateTime? ClearTime { get; set; }
        public string ErrorType { get; set; } = "ESD_NG"; // ESD_NG, DISCONNECTED
        public bool IsCleared { get; set; } = false;

        // Navigation Properties
        public virtual MonitorDevice MonitorDevice { get; set; } = null!;
        public virtual Station Station { get; set; } = null!;
    }
}
