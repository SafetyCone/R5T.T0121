using System;


namespace R5T.T0121
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class RegexPatternOperator : IRegexPatternOperator
    {
        #region Static
        
        public static RegexPatternOperator Instance { get; } = new();

        #endregion
    }
}