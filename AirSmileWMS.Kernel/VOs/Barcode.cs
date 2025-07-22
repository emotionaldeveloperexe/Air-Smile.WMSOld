using AirSmileWMS.Kernel.Services;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// Баркод.
    /// </summary>
    public sealed class Barcode : VO<Barcode, string>
    {
        private Barcode(string value) : base(value) { }

        protected override string Guard(string value) => Validate.Barcode(value);

        public static implicit operator Barcode(string value) => new Barcode(value);
    }
}
