using System;

using R5T.T0121;
using R5T.T0121.X001;


namespace System
{
    public static class IRegexPatternExtensions
    {
        public static string AllNonAlphanumeric(this IRegexPattern _)
        {
            return RegexPatterns.AllNonAlphanumeric;
        }
    }
}