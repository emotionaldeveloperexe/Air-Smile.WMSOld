using System;
using AirSmileWMS.Kernel.VOs;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Приход товара. Создается по факту прихода.
    /// </summary>
    public class GoodArrival
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
        /// Поступляемый товар.
        /// </summary>
        public virtual Good Good { get; set; }

        /// <summary>
        /// Сколько товара поступило. Задается пользователем.
        /// </summary>
        public Amount Count { get; set; }

        /// <summary>
        /// Дата поступления. Задается автоматически.
        /// </summary>
        public DateTime Date { get; set; }
    }
}
