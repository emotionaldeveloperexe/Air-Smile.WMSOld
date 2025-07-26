using System;

namespace AirSmileWMS.Kernel.Models
{
    /// <summary>
    /// От него наследуются все объекты, которые являются моделями.
    /// </summary>
    public abstract class Model
    {
        /// <summary>
        /// Дата создания записи в БД.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
