namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// От него наследуются все задания, которые именно для поставки.
    /// </summary>
    public abstract class TaskForSupplyDTO : TaskUserDTO
    {
        /// <summary>
        /// На какую поставку задание.
        /// </summary>
        public int TaskToSupplyId { get; set; }

        /// <summary>
        /// Сколько по факту собрано.
        /// </summary>
        public uint Count { get; set; }
    }
}
