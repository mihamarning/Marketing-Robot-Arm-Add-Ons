using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Assets.View
{
    public class ButtonsController : MonoBehaviour
    {
        [SerializeField]
        GameObject RemoveAllFittingsButton;

        void Update()
        {
            ButtonObserve(FittingState.Instance.CurrentLastFitting);
        }

        /// <summary>
        /// Enable button if any fittings are selected.
        /// </summary>
        /// <param name="lastFittingState"></param>
        private void ButtonObserve(GameObject lastFittingState)
        {
            if (lastFittingState != null)
            {
                if (!RemoveAllFittingsButton.activeSelf)
                {
                    RemoveAllFittingsButton.SetActive(true);
                }
            }
        }

        public void RemoveAllFittings()
        {
            FittingState.Instance.RemoveAllFittings();
            SideMenu.Instance.ShowOnlyViableOptions();
            RemoveAllFittingsButton.SetActive(false);
        }
    }
}
