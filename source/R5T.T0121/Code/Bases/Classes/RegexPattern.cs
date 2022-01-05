using System;


namespace R5T.T0121
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RegexPattern : IRegexPattern
    {
        #region Static
        
        public static RegexPattern Instance { get; } = new();

        #endregion
    }
}