using AirSmileWMS.Kernel.Services;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// Артикул.
    /// </summary>
    public sealed class SKU : VO<SKU, string>
    {
        private SKU(string value) : base(value) { }

        protected override string Guard(string value) => Validate.SKU(value);

        public static implicit operator SKU(string value) => new SKU(value);
    }
}
