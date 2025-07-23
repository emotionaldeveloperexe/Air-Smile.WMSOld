using AirSmileWMS.Kernel.VOs;
using System.Collections.Generic;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Продаваемый набор.
    /// </summary>
    public class Pack
    {
        /// <summary>
        /// Идентификатор для EF. Задается автоматически.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Изображение набора. Задается пользователем.
        /// </summary>
        public Image Image { get; set; }

        /// <summary>
        /// Наименование набора. Задается пользователем.
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        /// Артикул продавца. Задается пользователем.
        /// </summary>
        public SKU SellerSKU { get; set; }

        /// <summary>
        /// Артикул вб. Задается пользователем.
        /// </summary>
        public SKU WbSKU { get; set; }

        /// <summary>
        /// Баркод набора. Задается пользователем.
        /// </summary>
        public Barcode Barcode { get; set; }

        /// <summary>
        /// QR-код на сборку. Задается пользователем. Необязательный параметр.
        /// </summary>
        public QR QR { get; set; }

        /// <summary>
        /// Сложность сборки. Задается пользователем.
        /// </summary>
        public Amount Difficulty { get; set; }

        /// <summary>
        /// Состав набора.
        /// </summary>
        public virtual ICollection<PackGood> Goods { get; set; }

        /// <summary>
        /// Задания по набору.
        /// </summary>
        public virtual ICollection<TaskToSupply> TasksToSupply { get; set; }
    }
}
