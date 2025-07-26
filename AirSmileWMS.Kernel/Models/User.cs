using AirSmileWMS.Kernel.VOs;
using System.Collections.Generic;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Пользователь нашей скромной WMS :)
    /// </summary>
    public class User : Model
    {
        /// <summary>
        /// Идентификатор для EF. Задается автоматически.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование пользователя. Задается пользователем.
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Роль пользователя. Задается пользователем.
        /// </summary>
        public Name Role { get; set; }

        /// <summary>
        /// Код для входа в систему. Задается пользователем.
        /// </summary>
        public PIN Code { get; set; }

        /// <summary>
        /// Имеет ли пользователь права администратора.
        /// </summary>
        public bool IsAdmin { get; set; }  

        /// <summary>
        /// Действия пользователя.
        /// </summary>
        public virtual ICollection<UserAction> Actions { get; set; }

        /// <summary>
        /// Задания пользователя.
        /// </summary>
        public virtual ICollection<Task> Tasks { get; set; }

        /// <summary>
        /// Задания пользователя на сборку.
        /// </summary>
        public virtual ICollection<TaskToCollect> TasksToCollect { get; set; }

        /// <summary>
        /// Задания пользователя на упаковку.
        /// </summary>
        public virtual ICollection<TaskToPack> TasksToPack { get; set; }
    }
}
