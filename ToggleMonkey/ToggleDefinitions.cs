using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToggleMonkey
{
    public interface IFeatureToggle
    {
        bool IsFeatureEnabled(ToggleableFeatures featureName);
        bool IsFeatureEnabled(string featureName);
    }

    public enum ToggleableFeatures
    {
    }
}
