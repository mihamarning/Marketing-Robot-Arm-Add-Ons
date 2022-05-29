using Assets.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Presenter
{
    public static class FittingStatePresenter
    {
        private static  FittingState fittingStateInstance;

        /// <summary>
        /// Defaults to empty array
        /// </summary>
        public static FittingLevel[] CurrentFittingLevels { get; private set; } = new FittingLevel[0];


        public static void InitializeFittingState(FittingState fittingState)
        {
            fittingStateInstance = fittingState;
            CurrentFittingLevels = new FittingLevel[] { FittingLevel.L1 };
        }

        public static void SetFittingState(FittingLevel[] fittingLevels)
        {
            if (fittingLevels != null)
                CurrentFittingLevels = fittingStateInstance.FittingLevels = fittingLevels;
            else
                CurrentFittingLevels = fittingStateInstance.FittingLevels = new FittingLevel[0];
        }

        public static void CheckFittingState(FittingLevel nextFittingLevel)
        {
           
        }

    }

    /// <summary>
    /// All different types of fittings
    /// </summary>
    public enum FittingTypes
    {
        OAFitting = 0,
        Extender = 1,
        Camera = 2,
    }

    /// <summary>
    /// Indicates how many fittings are fitted between .this fitting and robot arm.
    /// </summary>
    public enum FittingLevel
    {
        /// <summary>
        /// Can be fitted directly to the robot arm.
        /// </summary>
        L1 = 0,
        /// <summary>
        /// Can be fitted on to the extender
        /// </summary>
        L2 = 1,
        /// <summary>
        /// Can be fitted to the top of the OA-mount
        /// </summary>
        L3 = 2,
    }

    public enum FittingOrientation
    {
        /// <summary>
        /// OA mounts can be rotated with respect to their to arm mounting face 
        /// </summary>
        NormalMountingFace = 0,
        /// <summary>
        /// OA mounts can be rotated with respect to their to arm mounting face 
        /// </summary>
        InvertedMountingFace = 1,
    }

    /// <summary>
    /// In case the extender is used, one can change the rotation of OA fitting around it's x axis
    /// </summary>
    public enum FittingRotation
    {
        Zero = 0,
        FourtyFive = 45,
        Ninety = 90,
        OneHundretThirtyFive = 135,
        OneHundretEighty = 180,
        TwoHundretTwentyFive = 225,
        TwoHundretSeventy = 270,
        ThreeHundretFifteen = 315,
        TreHundretSixty = 360,

    }
}
