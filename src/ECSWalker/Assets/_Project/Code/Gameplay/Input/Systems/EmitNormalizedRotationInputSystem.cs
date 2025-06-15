using Entitas;

namespace ECSWalker.Gameplay.Input
{
    public class EmitNormalizedRotationInputSystem : IExecuteSystem
    {
        private readonly IInputProvider _inputProvider;
        private readonly IGroup<InputEntity> _inputs;

        public EmitNormalizedRotationInputSystem(
            InputContext input,
            IInputProvider inputProvider)
        {
            _inputProvider = inputProvider;
            
            _inputs = input.GetGroup(InputMatcher
                .AllOf(
                    InputMatcher.Input,
                    InputMatcher.NormalizedRotationInput));
        }

        public void Execute()
        {
            foreach (InputEntity input in _inputs)
            {
                if (_inputProvider.HasRotationInput)
                    input.ReplaceInputAxis(_inputProvider.GetRawRotationInput().normalized);
                else if (input.hasInputAxis)
                    input.RemoveInputAxis();
            }
        }
    }
}