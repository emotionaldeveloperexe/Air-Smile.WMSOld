using AirSmileWMS.Kernel.Services;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// Ссылка.
    /// </summary>
    public sealed class Link : VO<Link, string>
    {
        private Link(string value) : base(value) { }

        protected override string Guard(string value) => Validate.Link(value);

        public static implicit operator Link(string value) => new Link(value);
    }
}
