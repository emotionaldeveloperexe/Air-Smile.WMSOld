using AirSmileWMS.Kernel.Services;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// Описание.
    /// </summary>
    public sealed class Description : VO<Description, string>
    {
        private Description(string value) : base(value) { }

        protected override string Guard(string value) => Validate.Description(value);

        public static implicit operator Description(string value) => new Description(value);
    }
}
