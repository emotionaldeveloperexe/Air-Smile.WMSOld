using AirSmileWMS.Kernel.VOs;
using System;
using System.Collections.Generic;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Поставка.
    /// </summary>
    public class Supply : Model
    {
        /// <summary>
        /// Идентификатор для EF. Задается автоматически.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор направления для EF. Задается пользователем.
        /// </summary>
        public int DirectionId { get; set; }

        /// <summary>
        /// Направление поставки.
        /// </summary>
        public virtual Direction Direction { get; set; }

        /// <summary>
        /// Номер поставки. Задается пользователем.
        /// </summary>
        public Barcode Number { get; set; }

        /// <summary>
        /// Дата поставки. Задается пользователем.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Задания по поставке.
        /// </summary>
        public virtual ICollection<TaskToSupply> Tasks { get; set; }
    }
}
