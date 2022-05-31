using Assets.Presenter;
using UnityEngine;

namespace Assets.Model
{
    public class OAFitting :  IHaveUpwardCompatibility, IHaveDownwardCompatibility, IInvertable
    {
        //In production his data should be fetched from database
        public FittingLevel[] UpwardFittingLevels { get; set; } = new FittingLevel[] {  FittingLevel.L3 };
        public FittingLevel[] DownwardFittingLevel { get; set; } = new FittingLevel[] { FittingLevel.L1, FittingLevel.L2 };
        public FittingOrientation FittingOrientation { get; set ; } = FittingOrientation.NormalMountingFace;

    }
}
