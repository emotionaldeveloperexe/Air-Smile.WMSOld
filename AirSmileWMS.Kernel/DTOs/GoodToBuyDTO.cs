namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных товара в список покупок.
    /// </summary>
    public sealed class GoodToBuyDTO : GoodWorkDTO
    {
        /// <summary>
        /// Сколько товара нужно купить.
        /// </summary>
        public uint Count { get; set; }
    }
}
