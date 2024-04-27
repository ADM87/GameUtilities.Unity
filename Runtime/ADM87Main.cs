using ADM87.GameUtilities.ServiceProvider;
using UnityEngine;

namespace AMD87.GameUtilities
{
    internal static class ADM87Main
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        private static void Initialize()
        {
            Services.CollectServiceDefinitions();
        }
    }
}
