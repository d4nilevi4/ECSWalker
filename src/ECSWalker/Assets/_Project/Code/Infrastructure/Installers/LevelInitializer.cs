using UnityEngine;
using Zenject;

namespace ECSWalker.Infrastructure
{
    public class LevelInitializer : MonoBehaviour
    {
        [Inject]
        private void Construct()
        {
        }

        private void Awake()
        {
        }
    }
}