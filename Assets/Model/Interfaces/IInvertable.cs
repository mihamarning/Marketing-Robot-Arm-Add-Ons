using Assets.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Model
{
    /// <summary>
    /// This object can be rotated 180 degrees along it's y axis
    /// </summary>
    interface IInvertable
    {
        FittingOrientation FittingOrientation { get; set; }
    }
}
