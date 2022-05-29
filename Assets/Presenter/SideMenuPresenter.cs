using Assets.Model;
using Assets.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Presenter
{

    public class SideMenuPresenter
    {
        private SideMenu sideMenu;

        public SideMenuPresenter(SideMenu sideMenu)
        {
            this.sideMenu = sideMenu;
        }

        /// <summary>
        /// Returns a list of GameObjects to display in the side menu scroll view.
        /// The list is refined with respect to current mounting state stored in FittingStatePresenter.
        /// </summary>
        /// <returns></returns>
        public List<GameObject> GetSidemenuItems(List<GameObject> AllSidemenuOptions)
        {
            List<GameObject> compatibleFittings = new List<GameObject>();

            foreach (GameObject fitting in AllSidemenuOptions)
            {
                if (fitting.GetComponent<FittingType>().TypeOfFitting == FittingTypes.OAFitting)
                {
                    var fittingModel = new OAFitting();
                    if (fittingModel.DownwardFittingLevel.Intersect(FittingStatePresenter.CurrentFittingLevels).ToList().Count > 0)
                    {
                        compatibleFittings.Add(fitting);
                    }
                }
                else if (fitting.GetComponent<FittingType>().TypeOfFitting == FittingTypes.Extender)
                {

                    var fittingModel = new ExtenderFitting();
                    if (fittingModel.DownwardFittingLevel.Intersect(FittingStatePresenter.CurrentFittingLevels).ToList().Count > 0)
                    {
                        compatibleFittings.Add(fitting);
                    }
                }
                else if (fitting.GetComponent<FittingType>().TypeOfFitting == FittingTypes.Camera)
                {
                    var fittingModel = new CameraFitting();
                    if (fittingModel.DownwardFittingLevel.Intersect(FittingStatePresenter.CurrentFittingLevels).ToList().Count > 0)
                    {
                        compatibleFittings.Add(fitting);
                    }
                }
            }
            return compatibleFittings;
        }

        public void SelectAFitting(GameObject selectedFitting)
        {
            if (selectedFitting.GetComponent<FittingType>().TypeOfFitting == FittingTypes.OAFitting)
            {
                var fittingModel = new OAFitting();
                FittingStatePresenter.SetFittingState(fittingModel.UpwardFittingLevels);


            }
            else if (selectedFitting.GetComponent<FittingType>().TypeOfFitting == FittingTypes.Extender)
            {
                var fittingModel = new ExtenderFitting();
                FittingStatePresenter.SetFittingState(fittingModel.UpwardFittingLevels);

            }
            else if (selectedFitting.GetComponent<FittingType>().TypeOfFitting == FittingTypes.Camera)
            {
                var fittingModel = new CameraFitting();
                FittingStatePresenter.SetFittingState(null);
            }
            Debug.Log(FittingStatePresenter.CurrentFittingLevels);
        }
    }
}
