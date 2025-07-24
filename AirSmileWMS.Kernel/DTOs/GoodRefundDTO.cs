namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных возврата товара.
    /// </summary>
    public sealed class GoodRefundDTO : GoodMoveDTO
    {
        /// <summary>
        /// Почему товар возвращается.
        /// </summary>
        public string Description { get; set; }
    }
}
