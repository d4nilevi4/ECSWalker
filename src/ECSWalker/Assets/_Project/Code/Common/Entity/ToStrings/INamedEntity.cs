using Entitas;

namespace ECSWalker.Common.Entity
{
    public interface INamedEntity : IEntity
    {
        string EntityName(IComponent[] components);
        string BaseToString();
    }
}