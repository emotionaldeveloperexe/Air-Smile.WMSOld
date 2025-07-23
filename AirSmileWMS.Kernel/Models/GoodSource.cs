using AirSmileWMS.Kernel.VOs;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Источник товара.
    /// </summary>
    public class GoodSource
    {
        /// <summary>
        /// Идентификатор для EF. Задается автоматически.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор товара для EF. Задается пользователем.
        /// </summary>
        public int GoodId { get; set; }

        /// <summary>
        /// Товар.
        /// </summary>
        public virtual Good Good { get; set; }

        /// <summary>
        /// Идентификатор поставщика для EF. Задается пользователем.
        /// </summary>
        public int GoodSupplierId { get; set; }

        /// <summary>
        /// Поставщик.
        /// </summary>
        public virtual GoodSupplier Supplier { get; set; }

        /// <summary>
        /// Артикул поставщика. Задается пользователем. Если поставщик не предоставляет артикулы то остается пустым.
        /// </summary>
        public SKU SKU { get; set; }

        /// <summary>
        /// Ссылка на товар. Задается пользователем. Если поставщик не предоставляет ссылки то остается пустым.
        /// </summary>
        public Link Link { get; set; }
    }
}
