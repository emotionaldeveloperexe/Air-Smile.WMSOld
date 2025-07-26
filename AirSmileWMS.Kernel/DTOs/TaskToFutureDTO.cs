namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных отложенного задания.
    /// </summary>
    public sealed class TaskToFutureDTO : TaskUserDTO
    {
        /// <summary>
        /// Какой набор отложен.
        /// </summary>
        public override int Id { get; set; }

        /// <summary>
        /// Сколько наборов нужно собрать. Задается автоматически.
        /// </summary>
        public uint Count { get; set; }
    }
}
