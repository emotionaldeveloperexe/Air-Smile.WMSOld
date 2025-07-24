namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных задания на поставку.
    /// </summary>
    public sealed class TaskToSupplyDTO : IDTO
    {
        /// <summary>
        /// Какой набор сделать.
        /// </summary>
        public int PackId { get; set; }

        /// <summary>
        /// На какую поставку идет задание.
        /// </summary>
        public int SupplyId { get; set; }

        /// <summary>
        /// Сколько наборов нужно сделать.
        /// </summary>
        public uint Count { get; set; }
    }
}
