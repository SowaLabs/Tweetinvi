using System;

namespace Tweetinvi.Core.Extensions
{
    public static class CompatibilityHelper
    {
        public static T TryGet<T>(Func<T> func)
        {
            try { return func(); }
            catch { return default(T); }
        }
    }
}
