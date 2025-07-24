namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных товара.
    /// </summary>
    public sealed class GoodDTO : IDTO
    {
        /// <summary>
        /// Какой категории будет принадлежать товар.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Путь до изображения товара.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Наименование товара.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Потребность товара.
        /// </summary>
        public uint NeedCount { get; set; }

        /// <summary>
        /// Остаток товара на складе.
        /// </summary>
        public uint Count { get; set; }
    }
}
