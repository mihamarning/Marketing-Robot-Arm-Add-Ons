using Assets.Presenter;
using Assets.View.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.View
{
    /// <summary>
    /// Highlander class. Provides the cross app "singleton" averseness of current fitting states.
    /// This allows for observer/observable pattern.
    /// </summary>
    public class FittingState : StaticInstance<FittingState>
    {

        [SerializeField]
        private GameObject fittings;

        private List<TransformHelper> originalTransforms = new List<TransformHelper>();
        //Cashed fittings
        private List<GameObject> allFittingsList = new List<GameObject>();

        /// <summary>
        /// The FittingLevels available to the next fitting. Defaults to Empty arm with no fittings attached!
        /// </summary>
        public FittingLevel[] CurrentFittingLevels { get; private set; } = new FittingLevel[] { FittingLevel.L1 };

        public GameObject CurrentLastFitting { get; private set; } = null;


        private void Start()
        {
            SaveAllFittingsOriginalTransforms(fittings);
        }

        /// <summary>
        /// Used later when we need to reposition all fittings to their original transforms
        /// </summary>
        /// <param name="fittings"></param>
        private void SaveAllFittingsOriginalTransforms(GameObject fittings)
        {
            foreach (Transform child in fittings.transform)
            {
                originalTransforms.Add(new TransformHelper(child.position, child.rotation));
                allFittingsList.Add(child.gameObject);
            }
              
        }

        /// <summary>
        /// Called when a fitting is selected. Changes the state.
        /// </summary>
        /// <param name="fittingLevels"></param>
        public void SetFittingState(FittingLevel[] fittingLevels, GameObject newFitting)
        {
            if (CurrentLastFitting != null)
            {
                GameObject fittingConnectorPoint = CurrentLastFitting.transform.GetChild(0).gameObject;
                RepositionTheFitting(newFitting, fittingConnectorPoint.transform.position, fittingConnectorPoint.transform.rotation);
            }
            if (fittingLevels != null)
                CurrentFittingLevels = fittingLevels;
            else
                CurrentFittingLevels = new FittingLevel[0];
            CurrentLastFitting = newFitting;
        }

        public void RepositionTheFitting(GameObject fitting, Vector3 nextPosition, Quaternion nextRotation)
        {
            fitting.transform.position = nextPosition;
            fitting.transform.rotation = nextRotation;
        }


        /// <summary>
        /// Returns all fittings that are currently fitted onto the arm.
        /// </summary>
        /// <returns>A list of fittings fitted onto the arm.</returns>
        public List<GameObject> ReturnFittedFittings()
        {
            List<GameObject> activeFittings = new List<GameObject>();
            //read on the go if in future these objects are created dynamically
            foreach (Transform child in fittings.transform)
                if (child.gameObject.activeSelf)
                    activeFittings.Add(child.gameObject);
            return activeFittings;
        }

        public void RemoveAllFittings()
        {
            int i = 0;
            allFittingsList.ForEach(fitting => {
                if (fitting.activeSelf)
                    fitting.SetActive(false);
                RepositionTheFitting(fitting, originalTransforms[i].Position, originalTransforms[i].Rotation);
                i++;
            });
            CurrentFittingLevels = new FittingLevel[] { FittingLevel.L1 };
            CurrentLastFitting = null;
        }

        /// <summary>
        /// A helper class used to store some of Unityengine.transform's  data.
        /// </summary>
        private class TransformHelper
        {
            public Vector3 Position { get; private set; }
            public Quaternion Rotation { get; private set; }

            public TransformHelper(Vector3 Position, Quaternion Rotation)
            {
                this.Rotation = Rotation;
                this.Position = Position;
            }
        }


    }
}
