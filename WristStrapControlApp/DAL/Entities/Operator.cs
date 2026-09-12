using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WristStrapControlApp.DAL.Entities
{
    public class Operator
    {
        [Key]
        public int OperatorId { get; set; }
        public string OperatorCode { get; set; } = string.Empty; // Mã NV (ví dụ: NV001)
        public string FullName { get; set; } = string.Empty;     // Nguyen Van A
        public string? Department { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public virtual ICollection<WristStrapLog> WristStrapLogs { get; set; } = new List<WristStrapLog>();
    }
}
