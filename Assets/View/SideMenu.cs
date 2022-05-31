using Assets.Model;
using Assets.Presenter;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace Assets.View
{
    /// <summary>
    /// The left side of the canvas is populated with a scroll view menu of items.
    /// </summary>
    public class SideMenu : MonoBehaviour
    {
        [SerializeField]
        private GameObject sideMenuContent; 
        private List<GameObject> allSidemenuOptions = new List<GameObject>();
        private  List<GameObject> sideMenuOptions { get;  set; }
        private SideMenuPresenter sideMenuPresenter;

        void Start()
        {
            Debug.Log(new FittingModel().FittingPosition);
            sideMenuPresenter = new SideMenuPresenter(this);

            if (sideMenuContent != null)
            {
                foreach (Transform child in sideMenuContent.transform)
                    allSidemenuOptions.Add(child.gameObject);
                ShowOnlyViableOptions();
            }
        }

        /// <summary>
        /// Not all items can be fitted to the robot arm or previously fitted item. 
        /// This method activates only the ones that can be fitted to the current available fitting levels.
        /// </summary>
        private void ShowOnlyViableOptions()
        {
            sideMenuOptions = sideMenuPresenter.GetSidemenuItems(allSidemenuOptions);
            allSidemenuOptions.ForEach(option => option.SetActive(false));
            allSidemenuOptions.Intersect(sideMenuOptions).ToList().ForEach(option => option.SetActive(true));
        }

        /// <summary>
        /// Application user clicks on a fitting option.
        /// </summary>
        /// <param name="selectedOption">One of the items in a scroll view.</param>
        public void SelectAFitting(GameObject selectedOption)
        {
            sideMenuPresenter.SelectAFitting(selectedOption);
            ShowOnlyViableOptions();
        }
    }
}
