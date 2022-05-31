using Assets.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Presenter
{
    /**
     *  This file provides fitting descriptions that would 
     *  probably be fetched from a database (this would be classes).
     *  This makes this a Model file, but for the sake of
     *  example, Presenter namespace would make these definitions
     *  available to both the views and the models.
     */

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
