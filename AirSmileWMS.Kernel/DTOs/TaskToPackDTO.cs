namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных задания на упаковку.
    /// </summary>
    public sealed class TaskToPackDTO : TaskUserDTO
    {
        /// <summary>
        /// номер коробки, в которую упакованы наборы.
        /// </summary>
        public string BoxNumber { get; set; }

        /// <summary>
        /// Сколько наборов упаковано в коробку.
        /// </summary>
        public uint Count { get; set; }
    }
}
