using System.Collections.Generic;

namespace Martin.TestHelpers.Utils
{
    public class AssetRegister : IAssetRegister
    {
        private AssetRegister()
        {
            Personas=new PersonaList();
        }
        public static IAssetRegister Create()
        {
            return new AssetRegister();
        }

        public PersonaList Personas { get; private set; }
    }
}