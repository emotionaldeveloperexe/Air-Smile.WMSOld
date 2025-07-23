using System.Collections.Generic;
using AirSmileWMS.Kernel.VOs;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Поставщик товара.
    /// </summary>
    public class GoodSupplier
    {
        /// <summary>
        /// Идентификатор для EF. Задается автоматически.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование поставщика. Задается пользователем.
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Есть ли у поставщика артикулы. Задается пользователем.
        /// </summary>
        public bool IsHasSKUsInfo { get; set; }

        /// <summary>
        /// Есть ли у поставщика ссылки на товар. Задается пользователем.
        /// </summary>
        public bool IsHasLinksInfo { get; set; }

        /// <summary>
        /// Товары, поставляемые поставщиком.
        /// </summary>
        public virtual ICollection<GoodSource> Goods { get; set; }
    }
}
