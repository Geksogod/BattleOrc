using System;
using UnityEngine;

namespace Game.CoreContainer
{
    public class Core : MonoBehaviour
    {
        public static Core instance;
        [HideInInspector]
        public GameInitializer GameInitializer;
        [HideInInspector]
        public IdController IdController;
        [HideInInspector]
        public TypeController TypeController;

        private void Awake()
        {
            if (instance == this)
                Destroy(this);
            else
                instance = this;
            DontDestroyOnLoad(this);
        }

        private void Start()
        {
            GameInitializer = GameInitializer.instance;
            IdController = IdController.instance;
            TypeController = TypeController.instance;
        }
    }
}