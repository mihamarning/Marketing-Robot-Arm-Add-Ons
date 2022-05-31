using Assets.Presenter;
using UnityEngine;

namespace Assets.Model
{
    public class OAFitting : FittingModel, IHaveUpwardCompatibility, IHaveDownwardCompatibility, IInvertable
    {
        //In production his data should be fetched from database
        public FittingLevel[] UpwardFittingLevels { get; set; } = new FittingLevel[] {  FittingLevel.L3 };
        public FittingLevel[] DownwardFittingLevel { get; set; } = new FittingLevel[] { FittingLevel.L1, FittingLevel.L2 };
        public FittingOrientation FittingOrientation { get; set ; } = FittingOrientation.NormalMountingFace;

        /// <summary>
        /// Use only when position and 
        /// rotation of upward fittings are not needed.
        /// </summary>
        public OAFitting()
        {

        }

        public OAFitting(Vector3 position, Quaternion rotation)
        {
            FittingPosition = position;
            FittingRotation = rotation;
        }
    }
}
