namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных категории.
    /// </summary>
    public sealed class CategoryDTO : IDTO
    {
        /// <summary>
        /// Наименование категории.
        /// </summary>
        public string Name { get; set; }
    }
}
