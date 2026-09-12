namespace WristStrapControlApp.DAL.DTOs
{
    public class WristStrapHistoryDTO
    {
        public long LogId { get; set; }
        public int RowNo { get; set; }
        public string Date { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
        public string ProcessStation { get; set; } = string.Empty;
        public string OperatorName { get; set; } = string.Empty;
        public string OldStatus { get; set; } = "-";
        public string NewStatus { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;
    }
}