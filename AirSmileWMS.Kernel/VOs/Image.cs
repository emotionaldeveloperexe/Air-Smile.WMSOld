using AirSmileWMS.Kernel.Services;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// Хранит в себе путь до файла-изображения.
    /// </summary>
    public sealed class Image : VO<Image, string>
    {
        private Image(string value) : base(value) { }

        protected override string Guard(string value) => Validate.Image(value);

        public static implicit operator Image(string value) => new Image(value);
    }
}
