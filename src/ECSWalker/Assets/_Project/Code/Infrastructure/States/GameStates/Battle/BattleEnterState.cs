using _Project.Code.Gameplay.Features.Hero.Factory;
using Cysharp.Threading.Tasks;
using ECSWalker.Gameplay.Levels;

namespace ECSWalker.Infrastructure
{
    public class BattleEnterState : IState
    {
        private readonly IGameStateMachine _stateMachine;
        private readonly IHeroFactory _heroFactory;
        private readonly ILevelDataProvider _levelDataProvider;

        public BattleEnterState(
            IGameStateMachine stateMachine,
            IHeroFactory heroFactory,
            ILevelDataProvider levelDataProvider
        )
        {
            _stateMachine = stateMachine;
            _heroFactory = heroFactory;
            _levelDataProvider = levelDataProvider;
        }

        public async UniTask Enter()
        {
            PlaceHero();

            await _stateMachine.Enter<BattleLoopState>();
        }

        public UniTask Exit() =>
            UniTask.CompletedTask;

        private void PlaceHero()
        {
            _heroFactory.CreateHero(_levelDataProvider.PlayerSpawnPoint);
        }
    }
}