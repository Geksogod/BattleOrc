using System;
using Game.CoreContainer;
using UnityEngine;

namespace Game.ActorDataContainer
{
    [Serializable]
    public abstract class ActorData
    {
        public int Id
        {
            get => _id;
            protected set => _id = value;
        }
        
        [SerializeField, HideInInspector] private int _id = -1;
        
        public abstract bool IsCurType(System.Enum type);
        public abstract Enum CurType { get; }
        
        public virtual void Init()
        {
            if (_id == -1)
                _id = IdController.instance.GetNewId();
        }
    }
}
