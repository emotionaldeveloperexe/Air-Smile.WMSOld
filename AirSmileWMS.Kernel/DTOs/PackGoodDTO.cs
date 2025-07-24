namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных товара в наборе.
    /// </summary>
    public sealed class PackGoodDTO : IDTO
    {
        /// <summary>
        /// В каком наборе учавствует товар.
        /// </summary>
        public int PackId { get; set; }

        /// <summary>
        /// Какой товар учавствует в наборе.
        /// </summary>
        public int GoodId { get; set; }

        /// <summary>
        /// Сколько товара идет в набор.
        /// </summary>
        public uint Count { get; set; }
    }
}
