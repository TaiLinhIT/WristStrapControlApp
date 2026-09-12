using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WristStrapControlApp.DAL.Entities
{
    public class CurrentStationStatus
    {
        [Key]
        public int StationId { get; set; }
        public int? CurrentOperatorId { get; set; }
        public ESDStatus Status { get; set; } = ESDStatus.NotConnected;
        public DateTime LastUpdated { get; set; } = DateTime.Now;

        // Navigation Properties
        public virtual Station Station { get; set; } = null!;
        public virtual Operator? CurrentOperator { get; set; }
    }
}
