namespace AirSmileWMS.Kernel.DTOs
{
    /// <summary>
    /// Объект передачи данных пользователя.
    /// </summary>
    public sealed class UserDTO : DTO
    {
        /// <summary>
        /// Имя сотрудника.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Роль сотрудника в компании.
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Код для входа в систему.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Имеет ли пользователь права администратора.
        /// </summary>
        public bool IsAdmin { get; set; }
    }
}
