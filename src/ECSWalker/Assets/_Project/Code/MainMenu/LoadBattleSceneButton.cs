using Cysharp.Threading.Tasks;
using ECSWalker.Infrastructure;
using UnityEngine.UI;
using UnityEngine;
using Zenject;

namespace ECSWalker.MainMenu
{
    [RequireComponent(typeof(Button))]
    public class LoadBattleSceneButton : MonoBehaviour
    {
        private IGameStateMachine _gameStateMachine;
        private Button _button;

        [Inject]
        private void Construct(
            IGameStateMachine gameStateMachine
        )
        {
            _gameStateMachine = gameStateMachine;
        }
        
        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(OnLoadBattleSceneButtonPressed);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(OnLoadBattleSceneButtonPressed);
        }

        private void OnLoadBattleSceneButtonPressed()
        {
            _gameStateMachine
                .Enter<LoadingBattleState, string>(Scenes.BATTLE)
                .Forget();
        }
    }
}