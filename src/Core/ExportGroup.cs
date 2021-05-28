using System;

namespace DI
{
    public class ExportGroup
    {
        #region Constructor

        public ExportGroup(Type tExport, Type tInterface)
        {

        }

        #endregion

        #region Properties

        public Type TExport { get; }

        public Type TInterface { get; }

        #endregion
    }
}
