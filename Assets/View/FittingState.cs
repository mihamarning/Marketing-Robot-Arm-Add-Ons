using Assets.Presenter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.View
{
    public class FittingState : MonoBehaviour
    {
        /// <summary>
        /// Debug Purposes only
        /// </summary>
        [SerializeField]
        public FittingLevel[] FittingLevels;


        private void Awake()
        {
           FittingStatePresenter.InitializeFittingState(this);
        }
    }
}
