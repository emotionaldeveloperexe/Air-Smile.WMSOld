using AirSmileWMS.Kernel.VOs;
using System;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Действие пользователя в программе.
    /// </summary>
    public class UserAction
    {
        /// <summary>
        /// Идентификатор для EF. Задается автоматически.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор пользователя для EF. Задается автоматически.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Пользователь, который совершил действие.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Дата и время действия. Задается автоматически.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Описание действия. Задается автоматически.
        /// </summary>
        public Description Log { get; set; }
    }
}
