using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Model.Interfaces
{
    public interface IHaveFittingTransform
    {
         Vector3 FittingPosition { get;  set; }
         Quaternion FittingRotation { get;  set; }
    }
}
