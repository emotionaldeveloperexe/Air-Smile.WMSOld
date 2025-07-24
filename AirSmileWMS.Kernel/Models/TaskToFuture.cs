using AirSmileWMS.Kernel.VOs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Отложенное задание.
    /// </summary>
    public class TaskToFuture
    {
        /// <summary>
        /// Идентификатор набора для EF. Задается автоматически.
        /// </summary>
        [Key]
        [ForeignKey(nameof(Pack))]
        public int PackId { get; set; }

        /// <summary>
        /// Набор, который учавствует в задании.
        /// </summary>
        public virtual Pack Pack { get; set; }

        /// <summary>
        /// Сколько наборов нужно собрать. Задается автоматически.
        /// </summary>
        public Amount Count { get; set; }
    }
}
