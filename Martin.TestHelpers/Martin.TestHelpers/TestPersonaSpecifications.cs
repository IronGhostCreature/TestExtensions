using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Martin.TestHelpers.Utils;
using NUnit.Framework;
using Utils;

namespace Martin.TestHelpers
{
    [TestFixture]
    public class TestPersonaSpecifications
    {
        [Test]
        public void Can_create_test_persona()
        {
            //Arrange+Act
            var testPersona=new Assets.Persona();

            //Assert
            testPersona.Should().NotBe(null, "object initialized and therefore should not be null");
        }

        [Test]
        public void Can_register_persona()
        {
            //Arrange
            var testPersona=new Assets.Persona();
            var register=AssetRegister.Create();

            //Act
            register.Personas.Add(testPersona);
            //Assert
            register.Personas[0].Should().Be(testPersona);
        }
    }
}
