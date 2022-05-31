using Assets.Presenter;
using Assets.View.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.View
{
    /// <summary>
    /// Highlander class. Provides the cross app "singleton" averseness of current fitting states.
    /// </summary>
    public class FittingState : StaticInstance<FittingState>
    {
        [SerializeField]
        private GameObject fittingRotationPane;


        /// <summary>
        /// The FittingLevels available to the next fitting. Defaults to Empty arm with no fittings attached!
        /// </summary>
        public FittingLevel[] CurrentFittingLevels { get; private set; } = new FittingLevel[] { FittingLevel.L1 };

        public  CurrentLastFitting { get; private set; }


        /// <summary>
        /// Called when a fitting is selected. Changes the state.
        /// </summary>
        /// <param name="fittingLevels"></param>
        public void SetFittingState(FittingLevel[] fittingLevels)
        {
            if (fittingLevels != null)
                CurrentFittingLevels = fittingLevels;
            else
                CurrentFittingLevels = new FittingLevel[0];
        }


        /// <summary>
        /// Returns all fittings that are currently fitted onto the arm.
        /// </summary>
        /// <returns>A list of fittings fitted onto the arm.</returns>
        public List<GameObject> ReturnFittedFittings()
        {
            List<GameObject> activeFittings = new List<GameObject>();
            //read on the go if in future these objects are created dynamically
            foreach (Transform child in fittingRotationPane.transform)
                if (child.gameObject.activeSelf)
                    activeFittings.Add(child.gameObject);
            return activeFittings;
        }
    }
}
