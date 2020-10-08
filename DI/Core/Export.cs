using System;
using System.Collections.Generic;
using System.Text;

namespace DI
{
    public class Export
    {
        #region Constructor

        public Export(object instance, Type typeOfInstance)
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
