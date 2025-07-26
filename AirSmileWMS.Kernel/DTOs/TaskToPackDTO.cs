namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных задания на упаковку.
    /// </summary>
    public sealed class TaskToPackDTO : TaskForSupplyDTO
    {

        /// <summary>
        /// номер коробки, в которую упакованы наборы.
        /// </summary>
        public string BoxNumber { get; set; }
    }
}
