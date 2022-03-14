using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    public struct ExportDefinition
    {
        #region Constructor

        public Export()
        {
            Instance = instance;
            Type = typeOfInstance;
        }

        #endregion

        #region Properties

        public Type Type { get; }

        public object Instance { get; }

        #endregion
    }
}
