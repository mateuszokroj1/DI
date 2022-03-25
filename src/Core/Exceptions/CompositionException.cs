using System;

namespace DI
{
    /*/// <summary>
    /// Is thrown when have some composition problems
    /// </summary>
    public class CompositionException : Exception
    {
        #region Constructors

        public CompositionException() : base("Exception in Composition") { }

        public CompositionException(string message)
            : base($"Exception in Composition: {message}")
            => Message = message;

        public CompositionException(string message, Composition composition)
            : this(message)
            => Composition = composition;

        public CompositionException(string message, Exception innerException)
            : base($"Exception in Composition: {message}", innerException)
            => Message = message;

        public CompositionException(string message, Composition composition, Exception innerException)
            : this(message, innerException)
            => Composition = composition;

        #endregion

        #region Properties

        public new string Message { get; }

        public Composition Composition { get; }

        #endregion
    }*/
}
