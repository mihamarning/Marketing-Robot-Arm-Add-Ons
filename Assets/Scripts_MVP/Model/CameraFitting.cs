using Assets.Presenter;

namespace Assets.Model
{
    public class CameraFitting : IHaveDownwardCompatibility
    {
        //In production his data should be fetched from database
        public FittingLevel[] DownwardFittingLevel { get; set; } = new FittingLevel[] { FittingLevel.L3 };
    }
}
