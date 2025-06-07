using ECSWalker.Infrastructure;

namespace ECSWalker.Gameplay.StaticData
{
    public class StaticDataService : IStaticDataService
    {
        private readonly IAssetProvider _assetProvider;
        
        public StaticDataService(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }

        public void LoadAll()
        {
        }
        
    }
}