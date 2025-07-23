﻿using AirSmileWMS.Kernel.VOs;
using System;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Задание на упаковку.
    /// </summary>
    public class TaskToPack
    {
        /// <summary>
        /// Идентификатор для EF. Задается автоматически.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор задания на поставку для EF. Задается автоматически.
        /// </summary>
        public int TaskToSupplyId { get; set; }

        /// <summary>
        /// Задание, которое нужно собрать.
        /// </summary>
        public virtual TaskToSupply Task { get; set; }

        /// <summary>
        /// Идентификатор пользователя для EF. Задается пользователем.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Исполнитель.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Дата начала работы. Задается пользователем не сразу.
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Дата выполнения задания. Задается пользователем не сразу.
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Номер коробки. Задается пользователем не сразу.
        /// </summary>
        public Barcode BoxNumber { get; set; }

        /// <summary>
        /// Сколько наборов по факту упаковано. Задается пользователем не сразу.
        /// </summary>
        public Amount Count { get; set; }
    }
}
