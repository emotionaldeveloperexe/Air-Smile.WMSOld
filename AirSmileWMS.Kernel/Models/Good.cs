using System.Collections.Generic;
using AirSmileWMS.Kernel.VOs;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Товар для набора.
    /// </summary>
    public class Good
    {
        /// <summary>
        /// Идентификатор для EF. Задается автоматически.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор категории для EF. Задается пользователем.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Категория товара.
        /// </summary>
        public virtual Category Category { get; set; }

        /// <summary>
        /// Изображение товара. Задается пользователем.
        /// </summary>
        public Image Image { get; set; }

        /// <summary>
        /// Наименование товара. Задается пользователем.
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Потребность товара. Задается пользователем. Редактируется системой.
        /// </summary>
        public Amount NeedCount { get; set; }

        /// <summary>
        /// Остаток товара на складе. Задается пользователем. Редактируется системой.
        /// </summary>
        public Amount Count { get; set; }

        /// <summary>
        /// Отслеживание товара. Необязательный параметр.
        /// </summary>
        public virtual GoodTracking Tracking { get; set; }

        /// <summary>
        /// Наличие товара в списке покупок. Необязательный параметр.
        /// </summary>
        public virtual GoodToBuy ToBuy { get; set; }

        /// <summary>
        /// Приходы товара.
        /// </summary>
        public virtual ICollection<GoodArrival> Arrivals { get; set; }

        /// <summary>
        /// Возвраты товара.
        /// </summary>
        public virtual ICollection<GoodRefund> Refunds { get; set; }

        /// <summary>
        /// Источники товара.
        /// </summary>
        public virtual ICollection<GoodSource> Sources { get; set; }

        /// <summary>
        /// Наборы, в которых учавствует товар.
        /// </summary>
        public virtual ICollection<PackGood> Packs { get; set; }
    }
}
