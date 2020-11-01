using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Game.ActorContainer;
using Game.GlobalEnum;
using Game.Storage;
using UnityEngine;
using UnityEngine.UI;

namespace Game.CoreContainer
{
    public class GameInitializer : MonoBehaviour
    {
        public static GameInitializer instance;
        [SerializeField]
        private Button spawnWizard;

        private void Awake()
        {
            if (instance == this)
                Destroy(this);
            else
                instance = this;
            DontDestroyOnLoad(this);
            spawnWizard.onClick.AddListener(() =>
                InitializeActor(GlobalActorEnum.FriendlyActor.Mage, Vector3.zero));
        }

        public Actor InitializeActor(GlobalActorEnum.FriendlyActor type, Vector3 actorPosition)
        {
            Actor newActor = ActorStorage.Instance.GetActor(type);
            GameObject actorObject =  Instantiate(newActor.gameObject);
            Vector3 _actorPosition = new Vector3(actorPosition.x,actorPosition.y,0);
            actorObject.transform.position = _actorPosition;
            return newActor;
        }
    }
}