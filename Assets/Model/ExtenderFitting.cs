using Assets.Presenter;

namespace Assets.Model
{
    public class ExtenderFitting :  IHaveUpwardCompatibility, IHaveDownwardCompatibility
    {
        //In production his data should be fetched from database
        public FittingLevel[] UpwardFittingLevels { get; set; } = new FittingLevel[] { FittingLevel.L2};
        public FittingLevel[] DownwardFittingLevel { get ; set; } = new FittingLevel[] { FittingLevel.L1 };
    }
}
