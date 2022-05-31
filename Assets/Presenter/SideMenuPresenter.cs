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
    /// <summary>
    /// Provides a translations of objects and logic between Views and Models.
    /// Sort of a buffer zone class to avoid models influencing the view and vice-versus.
    /// </summary>
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

            foreach (GameObject fittingOption in AllSidemenuOptions)
            {
                if (fittingOption.GetComponent<FittingType>().TypeOfFitting == FittingTypes.OAFitting)
                {
                    var fittingModel = new OAFitting();
                    if (fittingModel.DownwardFittingLevel.Intersect(FittingState.Instance.CurrentFittingLevels).ToList().Count > 0)
                    {
                        compatibleFittings.Add(fittingOption);
                    }
                }
                else if (fittingOption.GetComponent<FittingType>().TypeOfFitting == FittingTypes.Extender)
                {

                    var fittingModel = new ExtenderFitting();
                    if (fittingModel.DownwardFittingLevel.Intersect(FittingState.Instance.CurrentFittingLevels).ToList().Count > 0)
                    {
                        compatibleFittings.Add(fittingOption);
                    }
                }
                else if (fittingOption.GetComponent<FittingType>().TypeOfFitting == FittingTypes.Camera)
                {
                    var fittingModel = new CameraFitting();
                    if (fittingModel.DownwardFittingLevel.Intersect(FittingState.Instance.CurrentFittingLevels).ToList().Count > 0)
                    {
                        compatibleFittings.Add(fittingOption);
                    }
                }
            }
            return compatibleFittings;
        }

        public void SelectAFitting(GameObject selectedFitting)
        {
            if (selectedFitting.GetComponent<FittingType>().TypeOfFitting == FittingTypes.OAFitting)
            {
                var fittingModel = new OAFitting(selectedFitting.transform.position, selectedFitting.transform.rotation);
                FittingState.Instance.SetFittingState(fittingModel.UpwardFittingLevels);
                //selectedFitting.transform.position = fittingModel.FittingPosition;
            }
            else if (selectedFitting.GetComponent<FittingType>().TypeOfFitting == FittingTypes.Extender)
            {
                var fittingModel = new ExtenderFitting(selectedFitting.transform.position, selectedFitting.transform.rotation);
                FittingState.Instance.SetFittingState(fittingModel.UpwardFittingLevels);
            }
            else if (selectedFitting.GetComponent<FittingType>().TypeOfFitting == FittingTypes.Camera)
            {
                var fittingModel = new CameraFitting();
                FittingState.Instance.SetFittingState(null);
            }
        }
    }
}
