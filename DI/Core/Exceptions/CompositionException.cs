using System;

namespace DI
{
    public class CompositionException : Exception
    {
        #region Constructors

        public CompositionException(string message)
        {

        }

        #endregion

        #region Properties

        public new string Message { get; }

        #endregion
    }
}
