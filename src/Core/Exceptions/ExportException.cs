using System;

namespace DI
{
    public class ExportException : Exception
    {
        #region Constructors

        public ExportException() : base("Exception in Export") { }

        public ExportException(string message)
            : base($"Exception in Export: {message}")
        { }

        public ExportException(string message, Exception innerException)
            : base($"Exception in Composition: {message}", innerException)
        { }

        #endregion
    }
}
