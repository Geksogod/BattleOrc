using System;
using UnityEngine;
using Game.ActorDataContainer;
using Game.CoreContainer;

namespace Game.ActorContainer
{
    public class Actor : MonoBehaviour
    {
        public ActorData actorData;
        private Core Core;

        private void Awake()
        {
            Core = CoreContainer.Core.instance;
        }
    }
}
