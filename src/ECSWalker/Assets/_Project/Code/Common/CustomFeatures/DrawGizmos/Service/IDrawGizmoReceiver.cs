using System;

namespace ECSWalker.Common
{
    public interface IDrawGizmoReceiver
    {
        event Action EventDrawGizmo;
    }
}