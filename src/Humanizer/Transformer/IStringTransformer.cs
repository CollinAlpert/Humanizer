namespace Humanizer
{
    /// <summary>
    /// Can transform a string
    /// </summary>
    public interface IStringTransformer
    {
        /// <summary>
        /// Transform the input
        /// </summary>
        /// <param name="input">String to be transformed</param>
        string Transform(string input);
    }
}
