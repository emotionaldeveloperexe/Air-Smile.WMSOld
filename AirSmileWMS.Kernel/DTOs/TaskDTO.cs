namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных задания.
    /// </summary>
    public sealed class TaskDTO : TaskUserDTO
    {
        /// <summary>
        /// Что нужно сделать.
        /// </summary>
        public string Description { get; set; }
    }
}
