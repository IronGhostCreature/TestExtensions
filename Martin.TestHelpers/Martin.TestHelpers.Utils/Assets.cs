using Martin.TestHelpers.Utils;

namespace Utils
{
    public class Assets
    {
        public class Persona : IPersona
        {
            public string Name { get;private set; }

            public Persona(string name)
            {
                Name = name;
            }

            public Persona()
            {
            }
        }
    }
}