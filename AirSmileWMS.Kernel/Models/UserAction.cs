using AirSmileWMS.Kernel.VOs;
using System;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Действие пользователя в программе.
    /// </summary>
    public class UserAction : Model
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
        /// Описание действия. Задается автоматически.
        /// </summary>
        public Description Log { get; set; }
    }
}
