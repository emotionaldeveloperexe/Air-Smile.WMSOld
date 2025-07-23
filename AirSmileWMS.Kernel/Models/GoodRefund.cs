using System;
using AirSmileWMS.Kernel.VOs;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Возврат товара.
    /// </summary>
    public class GoodRefund
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
        /// Возвращаемый товар.
        /// </summary>
        public virtual Good Good { get; set; }

        /// <summary>
        /// Сколько товара возвращается. Задается пользователем.
        /// </summary>
        public Amount Count { get; set; }

        /// <summary>
        /// Описание, что случилось. Задается пользователем.
        /// </summary>
        public Description Description { get; set; }

        /// <summary>
        /// Дата создания возврата. Задается автоматически.
        /// </summary>
        public DateTime Date { get; set; }
    }
}
