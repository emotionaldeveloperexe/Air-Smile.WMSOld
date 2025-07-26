using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AirSmileWMS.Kernel.VOs;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Товар в списке покупок.
    /// </summary>
    public class GoodToBuy : Model
    {
        /// <summary>
        /// Идентификатор товара для EF. Задается пользователем.
        /// </summary>
        [Key]
        [ForeignKey(nameof(Good))]
        public int GoodId { get; set; }

        /// <summary>
        /// Товар к покупке.
        /// </summary>
        public virtual Good Good { get; set; }

        /// <summary>
        /// Сколько товара нужно купить. Задается пользователем.
        /// </summary>
        public Amount Count { get; set; }
    }
}
