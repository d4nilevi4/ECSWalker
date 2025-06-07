using Zenject;

namespace ECSWalker.Infrastructure
{
    public interface IMonoInstaller
    {
        void InstallBindings(DiContainer container);
    }
}