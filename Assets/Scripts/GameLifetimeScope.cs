using Assets.Scripts;
using VContainer;
using VContainer.Unity;

public class GameLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterComponentInHierarchy<PersistentScoreService>().As<IScoreService>();
        builder.RegisterComponentInHierarchy<PlayerCollect>();
    }
}
