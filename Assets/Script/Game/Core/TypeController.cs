using System.Collections;
using System.Collections.Generic;
using Game.ActorDataContainer;
using Game.GlobalEnum;
using UnityEngine;

public class TypeController : MonoBehaviour
{
    public static TypeController instance;

    private void Awake()
    {
        if (instance == this)
            Destroy(this);
        else
            instance = this;
        DontDestroyOnLoad(this);
    }

    public ActorData GetData(GlobalActorEnum.FriendlyActor actorType)
    {
        switch (actorType)
        {
            default:
                return new FriendlyActorData(actorType);
        }
    }
}
