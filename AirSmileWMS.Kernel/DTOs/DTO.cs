namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// От него наследуются все объекты, которые являются DTO.
    /// </summary>
    public abstract class DTO
    {
        /// <summary>
        /// Идентификатор для EF. 
        /// </summary>
        public virtual int Id { get; set; }
    }
}
