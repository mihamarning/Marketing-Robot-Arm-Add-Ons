using Assets.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Model
{
    public class Fitting
    {
        public List<FittingLevel> PossibleFittingLevels { get; private set; }

        public List<FittingOrientation> PossibleFittingOrientations { get; private set; }

        public List<FittingOrientation> PossibleFittingRotations { get; private set; }

    }
}
