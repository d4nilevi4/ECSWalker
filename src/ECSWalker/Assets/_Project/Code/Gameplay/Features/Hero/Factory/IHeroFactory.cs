using UnityEngine;

namespace _Project.Code.Gameplay.Features.Hero.Factory
{
    public interface IHeroFactory
    {
        GameEntity CreateHero(Vector3 at);
    }
}