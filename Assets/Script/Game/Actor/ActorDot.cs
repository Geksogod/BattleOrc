using System;
using System.Collections;
using System.Collections.Generic;
using Game.CoreContainer;
using UnityEngine;

namespace Game.ActorContainer
{
    public class ActorDot : MonoBehaviour
    {
        [SerializeField]
        private GlobalEnum.GlobalActorEnum.FriendlyActor _friendlyActor;

        private void Start()
        {
            Core.instance.GameInitializer.InitializeActor(_friendlyActor, transform.position);
            Destroy(gameObject);
        }
    }
}