namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных товара в список покупок.
    /// </summary>
    public sealed class GoodToBuyDTO : IDTO
    {
        /// <summary>
        /// Какой товар нужно купить.
        /// </summary>
        public int GoodId { get; set; }

        /// <summary>
        /// Сколько товара нужно купить.
        /// </summary>
        public uint Count { get; set; }
    }
}
