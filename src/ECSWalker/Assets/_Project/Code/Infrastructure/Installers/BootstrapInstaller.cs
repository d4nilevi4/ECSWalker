using System;
using _Project.Code.Gameplay.Features.Hero.Factory;
using Cysharp.Threading.Tasks;
using ECSWalker.Common;
using ECSWalker.Gameplay;
using ECSWalker.Gameplay.Cameras;
using ECSWalker.Gameplay.GroundDetection;
using ECSWalker.Gameplay.Input;
using ECSWalker.Gameplay.Levels;
using ECSWalker.Gameplay.StaticData;
using UnityEngine;
using Zenject;

namespace ECSWalker.Infrastructure
{
    public class BootstrapInstaller : MonoInstaller, IInitializable, ICoroutineRunner, IDrawGizmoReceiver
    {
        public event Action EventDrawGizmo;

        public override void InstallBindings()
        {
            BindInputService();
            BindInfrastructureServices();
            BindAssetManagementServices();
            BindCommonServices();
            BindSystemFactory();
            BindContexts();
            BindStateMachine();
            BindStateFactory();
            BindGameStates();
            BindGameplayServices();
            BindGameplayFactories();
            BindEntityIndices();

            Container.Bind<IInitializable>().FromInstance(this);
        }

        private void BindStateMachine()
        {
            Container.BindInterfacesAndSelfTo<GameStateMachine>().AsSingle();
        }

        private void BindStateFactory()
        {
            Container.BindInterfacesAndSelfTo<StateFactory>().AsSingle();
        }

        private void BindGameStates()
        {
            Container.BindInterfacesAndSelfTo<BootstrapState>().AsSingle();
            Container.BindInterfacesAndSelfTo<LoadProgressState>().AsSingle();
            Container.BindInterfacesAndSelfTo<LoadingMenuState>().AsSingle();
            Container.BindInterfacesAndSelfTo<MenuLoopState>().AsSingle();
            Container.BindInterfacesAndSelfTo<LoadingBattleState>().AsSingle();
            Container.BindInterfacesAndSelfTo<BattleEnterState>().AsSingle();
            Container.BindInterfacesAndSelfTo<BattleLoopState>().AsSingle();
        }

        private void BindContexts()
        {
            Container.Bind<Contexts>().FromInstance(Contexts.sharedInstance).AsSingle();

            Container.Bind<GameContext>().FromInstance(Contexts.sharedInstance.game).AsSingle();
            Container.Bind<InputContext>().FromInstance(Contexts.sharedInstance.input).AsSingle();
        }

        private void BindSystemFactory()
        {
            Container.Bind<ISystemFactory>().To<SystemFactory>().AsSingle();
        }

        private void BindInfrastructureServices()
        {
            Container.Bind<ICoroutineRunner>().FromInstance(this).AsSingle();
            Container.Bind<IIdentifierService>().To<IdentifierService>().AsSingle();
        }

        private void BindAssetManagementServices()
        {
            Container.Bind<IAssetProvider>().To<AssetProvider>().AsSingle();
        }

        private void BindCommonServices()
        {
            Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
            Container.Bind<ICollisionRegistry>().To<CollisionRegistry>().AsSingle();
            Container.Bind<IDrawGizmoReceiver>().FromInstance(this).AsSingle();
            Container.Bind<ILogger>().FromInstance(Debug.unityLogger).AsSingle();
        }

        private void BindInputService()
        {
            Container.BindInterfacesTo<InputProvider>().AsSingle();
        }

        private void BindGameplayServices()
        {
            Container.Bind<ITimeService>().To<UnityTimeService>().AsSingle();
            Container.Bind<IGroundDetectionHelper>().To<SphereCastGroundDetectionHelper>().AsSingle();
            Container.Bind<ICameraProvider>().To<CameraProvider>().AsSingle();
            Container.Bind<ILevelDataProvider>().To<LevelDataProvider>().AsSingle();
            Container.Bind<IStaticDataService>().To<StaticDataService>().AsSingle();
        }

        private void BindGameplayFactories()
        {
            Container.Bind<IEntityViewFactory>().To<EntityViewFactory>().AsSingle();
            Container.Bind<IHeroFactory>().To<HeroFactory>().AsSingle();
        }

        private void BindEntityIndices()
        {
            // Container.BindInterfacesAndSelfTo<GameEntityIndices>().AsSingle();
        }
        
        private void OnDrawGizmos()
        {
            EventDrawGizmo?.Invoke();
        }

        public void Initialize()
        {
            UniTaskScheduler.UnobservedTaskException += ex =>
            {
                Container
                    .Resolve<ILogger>()
                    .LogError(
                        tag: "¯\\_(ツ)_/¯", 
                        message: $"Unobserved exception: {ex}");
            };
        }
    }
}