namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных источника товара.
    /// </summary>
    public sealed class GoodSourceDTO : IDTO
    {
        /// <summary>
        /// Какой товар поставляется от источника.
        /// </summary>
        public int GoodId { get; set; }

        /// <summary>
        /// Кто поставщик товара.
        /// </summary>
        public int GoodSupplierId { get; set; }

        /// <summary>
        /// Артикул поставщика (если есть).
        /// </summary>
        public string SKU { get; set; }

        /// <summary>
        /// Ссылка на товар (если есть).
        /// </summary>
        public string Link { get; set; }
    }
}
