using AirSmileWMS.Kernel.VOs;
using System.Collections.Generic;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Направление (АВБ, ЯВБ, АО, ЯО и т д)
    /// </summary>
    public class Direction
    {
        /// <summary>
        /// Идентификатор для EF. Задается автоматически.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование направления. Задается пользователем.
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Является ли это направлением на склад. Задается пользователем.
        /// </summary>
        public bool IsStock { get; set; }

        /// <summary>
        /// Поставки по направлению.
        /// </summary>
        public virtual ICollection<Supply> Supplies { get; set; }
    }
}
