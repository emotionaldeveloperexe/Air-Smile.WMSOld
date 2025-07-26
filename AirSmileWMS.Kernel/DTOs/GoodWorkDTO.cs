namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных работы с конкретным товаром.
    /// </summary>
    public abstract class GoodWorkDTO : DTO
    {
        /// <summary>
        /// О каком товаре идет речь.
        /// </summary>
        public override int Id { get; set; }
    }
}
