using System;

namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных поставки.
    /// </summary>
    public sealed class SupplyDTO : IDTO
    {
        /// <summary>
        /// Какое направление поставки.
        /// </summary>
        public int DirectionId { get; set; }

        /// <summary>
        /// Какой номер поставки.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Какая дата поставки.
        /// </summary>
        public DateTime Date { get; set; }
    }
}
