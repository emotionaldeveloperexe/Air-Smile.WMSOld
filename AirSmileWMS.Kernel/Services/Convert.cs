using AirSmileWMS.Kernel.DTOs;
using AirSmileWMS.Kernel.Models;
using System;

namespace AirSmileWMS.Kernel.Services
{
    /// <summary>
    /// Конвертер между DTO и моделью БД.
    /// </summary>
    internal static class Convert
    {
        public static DTO ToDTO(Model model) 
        { 
            Throw(model);
            return null;
        }

        public static Model ToModel(DTO dto)
        {
            Throw(dto);
            return null;
        }

        private static void Throw(object obj) => throw new ArgumentException($"{nameof(obj)} является абстрактным классом. Используйте наследников.");
    }
}
