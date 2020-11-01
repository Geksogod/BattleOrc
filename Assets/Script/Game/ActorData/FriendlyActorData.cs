

using System;
using Game.GlobalEnum;

namespace Game.ActorDataContainer
{
    public class FriendlyActorData : ActorData
    {
        public GlobalActorEnum.FriendlyActor ActorType;
        public override Enum CurType => ActorType;

        public FriendlyActorData(GlobalActorEnum.FriendlyActor actorType)
        {
            ActorType = actorType;
        }
        
        public override bool IsCurType(Enum type)
        {
            return type is GlobalActorEnum.FriendlyActor actorType && actorType==ActorType;
        }

    }
}
