namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных направления.
    /// </summary>
    public sealed class DirectionDTO : DTO
    {
        /// <summary>
        /// Наименование направления.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Является ли это направлением на склад.
        /// </summary>
        public bool IsStock { get; set; }
    }
}
