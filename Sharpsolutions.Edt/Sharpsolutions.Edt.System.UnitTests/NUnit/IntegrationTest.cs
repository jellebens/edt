using NUnit.Framework;

namespace Sharpsolutions.Edt.System.UnitTests.NUnit {
    public class IntegrationTestAttribute : CategoryAttribute {
        public IntegrationTestAttribute() : base("Integration Test")
        {
        }
    }
}
