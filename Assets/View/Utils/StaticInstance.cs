using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.View.Utils
{
    /// <summary>
    /// There can be only one. A singleton mimic that instead of  destroying new instances, overrides current ones.
    /// DO NOT USE AWAKE IN CLASSES THAT INHERIT FROM THIS ONE.
    /// </summary>
    /// <typeparam name="T">Must be a class that extends a MonoBehaviour.</typeparam>
    public abstract class StaticInstance<T>:MonoBehaviour where T : MonoBehaviour
    {
        public static T Instance { get; private set; }

        protected virtual void Awake() => Instance = this as T;

        protected virtual void OnApplicationQuit()
        {
            Instance = null;
            Destroy(gameObject);
        }
    }
}
