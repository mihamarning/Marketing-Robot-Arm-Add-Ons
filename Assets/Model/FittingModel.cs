using Assets.Model.Interfaces;
using UnityEngine;

namespace Assets.Model
{
    public class FittingModel : IHaveFittingTransform
    {
        public Vector3 FittingPosition { get; set; }
        public Quaternion FittingRotation { get; set; }

        //TODO...
    }
}
