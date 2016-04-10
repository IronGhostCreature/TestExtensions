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

        [Test]
        public void Persona_has_name()
        {
            //Arrange
            const string expectedName = "cindy";

            //Act 
           var testPersona= new Assets.Persona(expectedName);

            //Assert
            testPersona.Name.Should().Be(expectedName);
        }

        [Test]
        public void Can_find_persona_by_name()
        {
            //Arrange 
            const string targetName = "laura";
            var register=AssetRegister.Create();
            var persona1=new Assets.Persona("fred");
            var persona2=new Assets.Persona("david");
            var targetPersona=new Assets.Persona(targetName);

            //Act
            register.Personas.Add(persona1);
            register.Personas.Add(persona2);
            register.Personas.Add(targetPersona);
            //Assert   
            register.Personas.Find(targetName);
        }
    }
}
