namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных продаваемого набора.
    /// </summary>
    public sealed class PackDTO : IDTO
    {
        /// <summary>
        /// Путь до изображения набора.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Наименование набора.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Артикул продавца.
        /// </summary>
        public string SellerSKU { get; set; }

        /// <summary>
        /// Артикул вб.
        /// </summary>
        public string WbSKU { get; set; }

        /// <summary>
        /// Баркод.
        /// </summary>
        public string Barcode { get; set; }

        /// <summary>
        /// Путь до QR-кода на сборку (если есть).
        /// </summary>
        public string QR { get; set; }

        /// <summary>
        /// Сложность набора.
        /// </summary>
        public uint Difficulty { get; set; }
    }
}
