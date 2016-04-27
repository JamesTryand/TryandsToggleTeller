namespace ToggleMonkey
{
    public class SomeFancyFeature : IFeatureToggle
    {
        public bool IsFeatureEnabled(ToggleableFeatures featureName)
        {
            return false;
        }

        public bool IsFeatureEnabled(string featureName)
        {
            return featureName == "Monkey";
        }
    }
}