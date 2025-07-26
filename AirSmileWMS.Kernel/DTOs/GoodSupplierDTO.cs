namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных поставщика товара.
    /// </summary>
    public sealed class GoodSupplierDTO : DTO
    {
        /// <summary>
        /// Наименование поставщика.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Есть ли у поставщика артикулы. 
        /// </summary>
        public bool IsHasSKUsInfo { get; set; }

        /// <summary>
        /// Есть ли у поставщика ссылки на товар.
        /// </summary>
        public bool IsHasLinksInfo { get; set; }
    }
}
