using System;

namespace DI
{
    public class CompositionException : Exception
    {
        #region Constructors

        public CompositionException() : base("Exception in Composition") { }

        public CompositionException(string message) : base($"Exception in Composition: {message}")
        {
            Message = message;
        }

        public CompositionException(string message, Exception innerException)
            : base($"Exception in Composition: {message}", innerException)
        {
            Message = message;
        }

        #endregion

        #region Properties

        public new string Message { get; }

        #endregion
    }
}
