using System.Collections.Generic;

namespace Martin.TestHelpers.Utils
{
    public class PersonaList:List<IPersona>
    {
        public IPersona Find(string name)
        {
          return Find(x => x.Name.Equals(name));
        }
    }
}