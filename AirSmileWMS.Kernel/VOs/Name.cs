using AirSmileWMS.Kernel.Services;

namespace AirSmileWMS.Kernel.VOs
{
    /// <summary>
    /// Наименование. 
    /// </summary>
    public sealed class Name : VO<Name, string>
    {
        private Name(string value) : base(value) { }

        protected override string Guard(string value) => Validate.Name(value);

        public static implicit operator Name(string value) => new Name(value);
    }
}
