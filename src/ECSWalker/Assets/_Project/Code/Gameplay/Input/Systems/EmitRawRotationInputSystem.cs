using Entitas;

namespace ECSWalker.Gameplay.Input
{
    public class EmitRawRotationInputSystem : IExecuteSystem
    {
        private readonly IInputProvider _inputProvider;
        private readonly IGroup<InputEntity> _inputs;

        public EmitRawRotationInputSystem(
            InputContext input,
            IInputProvider inputProvider)
        {
            _inputProvider = inputProvider;
            
            _inputs = input.GetGroup(InputMatcher
                .AllOf(
                    InputMatcher.Input,
                    InputMatcher.RawRotationInput));
        }

        public void Execute()
        {
            foreach (InputEntity input in _inputs)
            {
                if (_inputProvider.HasRotationInput)
                    input.ReplaceInputAxis(_inputProvider.GetRawRotationInput());
                else if (input.hasInputAxis)
                    input.RemoveInputAxis();
            }
        }
    }
}