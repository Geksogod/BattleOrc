using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.CoreContainer
{
    public class IdController :MonoBehaviour
    {
        public static IdController instance;

        private void Awake()
        {
            if (instance == this)
                Destroy(this);
            else
                instance = this;
            DontDestroyOnLoad(this);
        }
        
        
        public int GetNewId() => _nextId++;
        private int _nextId = 0;
    }
}
