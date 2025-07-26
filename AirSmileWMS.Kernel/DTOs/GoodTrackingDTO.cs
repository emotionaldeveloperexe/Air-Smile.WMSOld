namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных отслеживания товара.
    /// </summary>
    public sealed class GoodTrackingDTO : GoodWorkDTO
    {
        /// <summary>
        /// Что конкретно нужно сделать с товаром.
        /// </summary>
        public string Description { get; set; }
    }
}
