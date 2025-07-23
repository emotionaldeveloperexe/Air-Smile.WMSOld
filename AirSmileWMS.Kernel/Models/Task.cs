using AirSmileWMS.Kernel.VOs;
using System;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Задание.
    /// </summary>
    public class Task
    {
        /// <summary>
        /// Идентификатор для EF. Задается автоматически.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Описание задания. Задается пользователем.
        /// </summary>
        public Description Description { get; set; }

        /// <summary>
        /// Идентификатор пользователя для EF. Задается пользователем.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Исполнитель.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Дата создания задания. Задается автоматически.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Дата начала работы. Задается пользователем не сразу.
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Дата выполнения задания. Задается пользователем не сразу.
        /// </summary>
        public DateTime? CompletedAt { get; set; }
    }
}
