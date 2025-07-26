using System;

namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных исполнителя задания.
    /// </summary>
    public abstract class TaskUserDTO : DTO
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
