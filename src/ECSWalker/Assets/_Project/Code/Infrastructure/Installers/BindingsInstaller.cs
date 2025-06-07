using UnityEngine;
using Zenject;

namespace ECSWalker.Infrastructure
{
    public abstract class BindingsInstaller : MonoBehaviour, IMonoInstaller
    {
        public abstract void InstallBindings(DiContainer container);
    }
}