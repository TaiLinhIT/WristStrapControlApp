using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WristStrapControlApp.DAL.Entities
{
    public class WristStrapLog
    {
        [Key]
        public int Id { get; set; }

        // Đảm bảo có đúng thuộc tính Date
        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        [Column("ProcessStation")]
        public string ProcessStation { get; set; }

        // Đảm bảo Operator là kiểu string (không phải string[] hay List<string>)
        public string Operator { get; set; }

        public string OldStatus { get; set; }
        public string NewStatus { get; set; }
        public string Result { get; set; }
    }
}
