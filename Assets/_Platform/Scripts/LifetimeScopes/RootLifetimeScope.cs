using VContainer;
using VContainer.Unity;

namespace _Platform
{
    public class RootLifetimeScope : LifetimeScope
    {
        public AllPlayersConfig _allPlayersConfig;
        public AllItemsConfig _allItemsConfig;

        protected override void Configure(IContainerBuilder builder)
        {
            base.Configure(builder);
            
            builder.RegisterInstance(_allPlayersConfig).As<AllPlayersConfig>();
            builder.RegisterInstance(_allItemsConfig).As<AllItemsConfig>();
        }
    }
}