using ADM87.GameUtilities.Services;
using UnityEngine;

namespace AMD87.GameUtilities
{
    internal static class ADM87Main
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        private static void Initialize()
        {
            ServiceProvider.CollectServiceDefinitions();
        }
    }
}
