using AirSmileWMS.Kernel.VOs;
using System;
using System.Collections.Generic;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Задание на поставку.
    /// </summary>
    public class TaskToSupply : Model
    {
        /// <summary>
        /// Идентификатор для EF. Задается автоматически.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор набора для EF. Задается пользователем.
        /// </summary>
        public int PackId { get; set; }

        /// <summary>
        /// Набор, который учавствует в задании.
        /// </summary>
        public virtual Pack Pack { get; set; }

        /// <summary>
        /// Можно ли сразу сделать меньше наборов, если не будет хватать товара. 
        /// </summary>
        public bool IsCanBeLess { get; set; }

        /// <summary>
        /// Идентификатор поставки для EF. Задается пользователем.
        /// </summary>
        public int SupplyId { get; set; }

        /// <summary>
        /// Поставка, на которую идет задание.
        /// </summary>
        public virtual Supply Supply { get; set; }

        /// <summary>
        /// Сколько наборов нужно собрать. Задается пользователем.
        /// </summary>
        public Amount Count { get; set; }

        /// <summary>
        /// Сборка задания.
        /// </summary>
        public virtual TaskToCollect TaskToCollect { get; set; }

        /// <summary>
        /// Упаковка задания. Несколько на случай, если 2 человека разделят между собой наборы в задании.
        /// </summary>
        public virtual ICollection<TaskToPack> TasksToPack { get; set; }
    }
}
