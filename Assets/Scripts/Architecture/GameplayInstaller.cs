using ProjectAssets.Scripts.Architecture.MVP;
using ProjectAssets.Scripts.Architecture.MVP.Player;
using UnityEngine;
using Zenject;

public class GameplayInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IPlayerView>().To<PlayerView>().AsSingle();
    }
}
