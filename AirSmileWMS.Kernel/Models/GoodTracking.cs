using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AirSmileWMS.Kernel.VOs;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Отслеживание товара. Менеджеры добавляют сюда товар, которому нужно особое внимание.
    /// </summary>
    public class GoodTracking : Model
    {
        /// <summary>
        /// Идентификатор товара для EF. Задается пользователем.
        /// </summary>
        [Key]
        [ForeignKey(nameof(Good))]
        public int GoodId { get; set; }

        /// <summary>
        /// Отслеживаемый товар.
        /// </summary>
        public virtual Good Good { get; set; }

        /// <summary>
        /// Описание, что нужно сделать с товаром. Задается пользователем.
        /// </summary>
        public Description Description { get; set; }
    }
}
