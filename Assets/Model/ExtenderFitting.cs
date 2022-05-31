using Assets.Presenter;
using UnityEngine;

namespace Assets.Model
{
    public class ExtenderFitting : FittingModel, IHaveUpwardCompatibility, IHaveDownwardCompatibility
    {
        //In production his data should be fetched from database
        public FittingLevel[] UpwardFittingLevels { get; set; } = new FittingLevel[] { FittingLevel.L2};
        public FittingLevel[] DownwardFittingLevel { get ; set; } = new FittingLevel[] { FittingLevel.L1 };

        /// <summary>
        /// Use only when position and 
        /// rotation of upward fittings are not needed.
        /// </summary>
        public ExtenderFitting()
        {

        }

        public ExtenderFitting(Vector3 position, Quaternion rotation)
        {
            FittingPosition = position;
            FittingRotation = rotation;
        }
    }
}
