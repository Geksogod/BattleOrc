using System;
using System.Collections;
using System.Collections.Generic;
using Game.GlobalEnum;
using UnityEngine;


namespace Game.ActorDataContainer
{
    [SerializeField]
    public class EnemyActorData : ActorData
    {
        
        public GlobalActorEnum.EnemyActor ActorType;
        
        public EnemyActorData(GlobalActorEnum.EnemyActor actorType)
        {
            ActorType = actorType;
        }
        
        public override bool IsCurType(Enum type)
        {
            return type is GlobalActorEnum.EnemyActor actorType && actorType==ActorType;
        }

        public override Enum CurType { get; }
    }
}
