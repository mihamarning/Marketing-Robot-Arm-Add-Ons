using Assets.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Model
{
    /// <summary>
    /// Determines on what level of fitting this component can be fitted to.
    /// Interface of this and lower level component.
    /// </summary>
    public interface IHaveDownwardCompatibility
    {
        FittingLevel[] DownwardFittingLevel { get; set; }
    }
}
