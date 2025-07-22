using AirSmileWMS.Kernel.Services;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// ПИН-код.
    /// </summary>
    public sealed class PIN : VO<PIN, string>
    {
        private PIN(string value) : base(value) { }

        protected override string Guard(string value) => Validate.PIN(value);

        public static implicit operator PIN(string value) => new PIN(value);
    }
}
