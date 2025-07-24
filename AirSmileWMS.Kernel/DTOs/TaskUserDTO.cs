using System;

namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных исполнителя задания.
    /// </summary>
    public class TaskUserDTO : IDTO
    {
        /// <summary>
        /// Исполнитель.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Дата начала работы. 
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Дата выполнения задания. 
        /// </summary>
        public DateTime? CompletedAt { get; set; }
    }
}
