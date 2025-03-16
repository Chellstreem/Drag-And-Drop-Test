using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    [SerializeField] private GameConfig gameConfig;
    [SerializeField] private Camera firstCamera;

    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<GameConfig>()
            .FromInstance(gameConfig)
            .AsSingle();

        Container.Bind<Camera>()
            .FromInstance(firstCamera)
            .AsSingle()
            .NonLazy();

        Container.Bind<IDragger>()
            .To<Dragger>()
            .AsSingle();

        Container.Bind<IDropper>()
            .To<Dropper>()
            .AsSingle();

        Container.Bind<IPlacementHandler>()
            .To<PlacementHandler>()
            .AsSingle()
            .NonLazy();
    }
}
