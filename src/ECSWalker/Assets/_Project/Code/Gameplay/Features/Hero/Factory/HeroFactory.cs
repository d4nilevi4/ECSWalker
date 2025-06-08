using ECSWalker.Common;
using ECSWalker.Common.Entity;
using ECSWalker.Infrastructure;
using UnityEngine;

namespace _Project.Code.Gameplay.Features.Hero.Factory
{
    public class HeroFactory : IHeroFactory
    {
        private readonly IIdentifierService _identifierService;

        public HeroFactory(
            IIdentifierService identifierService
        )
        {
            _identifierService = identifierService;
        }

        public GameEntity CreateHero(Vector3 at)
        {
            return CreateEntity.Empty()
                    .AddId(_identifierService.Next())
                    .AddWorldPosition(at)
                    .AddDesiredVelocity(Vector3.zero)
                    .AddDirection(Vector3.zero)
                    .AddSpeed(5f)
                    .AddViewPath("Gameplay/Characters/Player/[Character] Player")
                    .With(x => x.isMovableByRigidbody = true)
                    .With(x => x.isMovementAvailable = true)
                    .With(x => x.isHero = true)
                ;
        }
    }
}