namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных задания на поставку.
    /// </summary>
    public sealed class TaskToSupplyDTO : DTO
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

        /// <summary>
        /// Можно ли сразу сделать меньше наборов, если не будет хватать товара. 
        /// </summary>
        public bool IsCanBeLess { get; set; }
    }
}
