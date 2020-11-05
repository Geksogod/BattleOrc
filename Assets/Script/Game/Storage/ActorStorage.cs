using System;
using Game.ActorContainer;
using Game.ActorDataContainer;
using Game.CoreContainer;
using Game.GlobalEnum;
using RotaryHeart.Lib.SerializableDictionary;
using UnityEngine;

namespace Game.Storage
{
    [CreateAssetMenu(fileName = "ActorStorage", menuName = "Storages/ActorStorage", order = 0)]
    public class ActorStorage : ScriptableObject
    {
        private const string Path = "Storage/ActorStorage";

        public static ActorStorage Instance => Resources.Load(Path) as ActorStorage; 
        
        [Serializable]
        public class FriendlyActorStorage : SerializableDictionaryBase<GlobalActorEnum.FriendlyActor, string>
        {
        }

        [SerializeField] private FriendlyActorStorage friendlyStorage;
        
        
        [Serializable]
        public class EnemyActorStorage : SerializableDictionaryBase<GlobalActorEnum.EnemyActor, string>
        {
        }

        [SerializeField] private EnemyActorStorage enemyActorStorage;

        public Actor GetActor(GlobalActorEnum.FriendlyActor friendlyActor)
        {
            foreach (var item in friendlyStorage)
            {
                if (friendlyActor == item.Key)
                {
                    GameObject newActor =  Resources.Load(item.Value) as GameObject;
                    Actor actor = newActor.GetComponent<Actor>();
                    actor.actorData = Core.instance.TypeController.GetData(friendlyActor);
                    return actor;
                }
            }
            throw new Exception("Cant find " + friendlyActor.ToString());
        }
        
        public Actor GetActor(GlobalActorEnum.EnemyActor enemyActor)
        {
            foreach (var item in enemyActorStorage)
            {
                if (enemyActor == item.Key)
                {
                    GameObject newActor =  Resources.Load(item.Value) as GameObject;
                    Actor actor = newActor.GetComponent<Actor>();
                    actor.actorData = Core.instance.TypeController.GetData(enemyActor);
                    return actor;
                }
            }
            throw new Exception("Cant find " + enemyActor.ToString());
        }
    }
}