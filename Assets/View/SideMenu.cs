using Assets.Model;
using Assets.Presenter;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace Assets.View
{
    public class SideMenu : MonoBehaviour
    {
        [SerializeField]
        private GameObject SideMenuContent; 

        private List<GameObject> AllSidemenuOptions = new List<GameObject>();
        private  List<GameObject> SideMenuOptions { get;  set; }

        private SideMenuPresenter sideMenuPresenter;

        void Start()
        {
            sideMenuPresenter = new SideMenuPresenter(this);

            if (SideMenuContent != null)
            {
                foreach (Transform child in SideMenuContent.transform)
                    AllSidemenuOptions.Add(child.gameObject);
                ShowOnlyViableOptions();
            }
        }

        private void ShowOnlyViableOptions()
        {
            SideMenuOptions = sideMenuPresenter.GetSidemenuItems(AllSidemenuOptions);
            AllSidemenuOptions.ForEach(option => option.SetActive(false));
            AllSidemenuOptions.Intersect(SideMenuOptions).ToList().ForEach(option => option.SetActive(true));
        }

        public void SelectAFitting(GameObject selectedOption)
        {
            sideMenuPresenter.SelectAFitting(selectedOption);
            ShowOnlyViableOptions();
        }

    }
}
