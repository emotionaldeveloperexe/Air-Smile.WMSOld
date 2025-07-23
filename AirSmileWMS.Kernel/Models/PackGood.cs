using AirSmileWMS.Kernel.VOs;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// Товар в наборе.
    /// </summary>
    public class PackGood
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
        /// Набор, в котором учавствует товар.
        /// </summary>
        public virtual Pack Pack { get; set; }

        /// <summary>
        /// Идентификатор товара для EF. Задается пользователем.
        /// </summary>
        public int GoodId { get; set; }

        /// <summary>
        /// Товар, который учавствует в наборе.
        /// </summary>
        public virtual Good Good { get; set; }

        /// <summary>
        /// Сколько товара идет в набор. Задается пользователем.
        /// </summary>
        public Amount Count { get; set; }
    }
}
