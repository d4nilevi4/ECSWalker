using Cysharp.Threading.Tasks;
using ECSWalker.Gameplay.StaticData;

namespace ECSWalker.Infrastructure
{
    public class BootstrapState : IState
    {
        private readonly IGameStateMachine _stateMachine;
        private readonly IStaticDataService _staticDataService;

        public BootstrapState(
            IGameStateMachine stateMachine,
            IStaticDataService staticDataService)
        {
            _stateMachine = stateMachine;
            _staticDataService = staticDataService;
        }

        public async UniTask Enter()
        {
            _staticDataService.LoadAll();
            
            await _stateMachine.Enter<LoadProgressState>();
        }

        public UniTask Exit() =>
            UniTask.CompletedTask;
    }
}