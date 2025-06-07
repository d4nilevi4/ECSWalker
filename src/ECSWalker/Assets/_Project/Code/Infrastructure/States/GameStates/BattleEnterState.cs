using Cysharp.Threading.Tasks;

namespace ECSWalker.Infrastructure
{
    public class BattleEnterState : IState
    {
        private readonly IGameStateMachine _stateMachine;

        public BattleEnterState(
            IGameStateMachine stateMachine
        )
        {
            _stateMachine = stateMachine;
        }

        public async UniTask Enter()
        {
            PlaceHero();

            await _stateMachine.Enter<BattleLoopState>();
        }

        public UniTask Exit()
        {
            return UniTask.CompletedTask;
        }

        private void PlaceHero()
        {
        }
    }
}