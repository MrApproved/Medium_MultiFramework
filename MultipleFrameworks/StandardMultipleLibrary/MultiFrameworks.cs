using System;

namespace StandardMultipleLibrary
{
    public class MultiFrameworks
    {
        public string Platform
        {
            get
            {
#if NET472
                return ".NET Framework";
#elif NETSTANDARD2_0
                return ".NET Standard";
#else
                return "Default";
#endif
            }
        }
    }
}
