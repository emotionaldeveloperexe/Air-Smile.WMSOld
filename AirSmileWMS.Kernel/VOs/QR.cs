using AirSmileWMS.Kernel.Services;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// Хранит в себе путь до файла с QR-кодом.
    /// </summary>
    public sealed class QR : VO<QR, string>
    {
        private QR(string value) : base(value) { }

        protected override string Guard(string value) => Validate.QR(value);

        public static implicit operator QR(string value) => new QR(value);
    }
}
