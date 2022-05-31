using Assets.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Model
{
    /// <summary>
    /// Interface of this and higher level component.
    /// </summary>
    public interface IHaveUpwardCompatibility
    {
        FittingLevel[] UpwardFittingLevels { get; set; }

    }
}
