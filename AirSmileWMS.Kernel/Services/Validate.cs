using System;
using System.IO;
using System.Text.RegularExpressions;

namespace AirSmileWMS.Kernel.Services
{
    /// <summary>
    /// Здесь собрана вся логика валидаций бизнес типов.
    /// </summary>
    internal static class Validate
    {
        private static readonly RegexOptions REGEX_OPTIONS = RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant;

        private static readonly Regex BARCODE_FORMAT = new Regex(@"^\d+$", REGEX_OPTIONS);
        private static readonly Regex PIN_FORMAT = new Regex(@"^\d{4}$", REGEX_OPTIONS);
        private static readonly Regex IMAGE_FORMAT = new Regex(@"^[\w,\s\-\\\/:]+\.((jpe?g|png|gif|bmp|webp|tiff|ico))\z", REGEX_OPTIONS);
        private static readonly Regex QR_FORMAT = new Regex(@"^[\w,\s\-\\\/:]+\.((jpe?g|png|bmp|webp|tiff|ico|svg|pdf))\z", REGEX_OPTIONS);

        private const byte MIN_DESCRIPTION_LENGTH = 10;

        /// <summary>
        /// Проверяет, что наименование заполнено.
        /// </summary>
        public static string Name(string name) => ThrowIfNullOrWhiteSpace(name, "Наименование");

        /// <summary>
        /// Проверяет, что артикул заполнен. Нет проверок на формат т. к. у каждого магазина свои непредсказуемые артикулы.
        /// </summary>
        public static string SKU(string sku) => ThrowIfNullOrWhiteSpace(sku, "Артикул");

        /// <summary>
        /// Проверяет, что баркод корректный.
        /// </summary>
        public static string Barcode(string barcode) => ThrowIfInvalidFormat(barcode, BARCODE_FORMAT, "Баркод должен состоять только из цифр.");

        /// <summary>
        /// Проверяет, что ПИН-код корректный.
        /// </summary>
        public static string PIN(string pin) => ThrowIfInvalidFormat(pin, PIN_FORMAT, "ПИН-код должен состоять только из 4 цифр.");

        /// <summary>
        /// Проверяет путь к изображению.
        /// </summary>
        public static string Image(string path) => ThrowIfInvalidFilePath(path, IMAGE_FORMAT);

        /// <summary>
        /// Проверяет путь к QR-файлу (расширения отличаются).
        /// </summary>
        public static string QR(string path) => ThrowIfInvalidFilePath(path, QR_FORMAT);

        /// <summary>
        /// Проверяет URL-ссылку.
        /// </summary>
        public static string Link(string url)
        {
            url = ThrowIfNullOrWhiteSpace(url, "URL");

            if (!Uri.TryCreate(url, UriKind.Absolute, out var uri) || (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps))
                throw new ArgumentException("Некорректная ссылка.");

            return url;
        }

        /// <summary>
        /// Проверяет, что описание не слишком короткое.
        /// </summary>
        public static string Description(string description)
        {
            description = ThrowIfNullOrWhiteSpace(description, "Описание");

            if (description.Length < MIN_DESCRIPTION_LENGTH)
                throw new ArgumentException("Описание должно быть более подробным.");

            return description;
        }

        /// <summary>
        /// Проверяет, что число не отрицательное.
        /// </summary>
        public static int Amount(int amount)
        {
            if (amount < 0)
                throw new ArgumentException("Параметр не может быть отрицательным.");

            return amount;
        }

        private static string ThrowIfNullOrWhiteSpace(string value, string paramName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"{paramName} не может быть пустым.");

            return value.Trim();
        }

        private static string ThrowIfInvalidFormat(string value, Regex format, string exceptionMessage)
        {
            if (string.IsNullOrWhiteSpace(value) || !format.IsMatch(value))
                throw new ArgumentException(exceptionMessage);

            return value;
        }

        private static string ThrowIfInvalidFilePath(string path, Regex format)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Путь к файлу не может быть пустым.");

            if (path.Contains("..") || path.IndexOfAny(Path.GetInvalidPathChars()) != -1)
                throw new ArgumentException("Некорректный путь к файлу.");

            if (!format.IsMatch(path))
                throw new ArgumentException("Недопустимое расширение файла.");

            if (!File.Exists(path))
                throw new ArgumentException("Файл не найден.");

            return path;
        }
    }
}
