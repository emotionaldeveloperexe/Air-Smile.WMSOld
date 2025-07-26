namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных перемещения товара.
    /// </summary>
    public abstract class GoodMoveDTO : DTO
    {
        /// <summary>
        /// Какой товар перемещается.
        /// </summary>
        public int GoodId { get; set; }

        /// <summary>
        /// Сколько товара перемещается.
        /// </summary>
        public uint Count { get; set; }
    }
}
