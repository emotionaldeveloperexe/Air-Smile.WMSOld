namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных задания на сборку.
    /// </summary>
    public sealed class TaskToCollectDTO : TaskUserDTO
    {
        /// <summary>
        /// Сколько по факту собрано.
        /// </summary>
        public uint Count { get; set; }
    }
}
