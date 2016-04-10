using System.Collections.Generic;

namespace Martin.TestHelpers.Utils
{
    public class AssetRegister : IAssetRegister
    {
        private AssetRegister()
        {
            Personas=new List<IPersona>();
        }
        public static IAssetRegister Create()
        {
            return new AssetRegister();
        }

        public List<IPersona> Personas { get; private set; }
    }
}