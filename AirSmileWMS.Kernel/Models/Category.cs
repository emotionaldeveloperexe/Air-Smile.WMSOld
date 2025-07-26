using System.Collections.Generic;
using AirSmileWMS.Kernel.VOs;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Категория товара.
    /// </summary>
    public class Category : Model
    {
        /// <summary>
        /// Идентификатор для EF. Задается автоматически.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование категории. Задается пользователем.
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Товары, которые принадлежат категории. 
        /// </summary>
        public virtual ICollection<Good> Goods { get; set; }
    }
}
