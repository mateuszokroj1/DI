using System;
using System.Collections.Generic;
using System.Linq;

using DI.Collections;

namespace DI
{
    public class Composition
    {
        #region Fields

        //internal List<Export> exports = new List<Export>();
        //internal List<ExportGroup> exportGroups = new List<ExportGroup>();

        #endregion

        #region Constructors

        public Composition() { }

        public Composition(Composition parrentComposition)
        {
            Parent = parrentComposition;
        }

        #endregion

        #region Properties

        public Composition Parent { get; }

        public CompositionCollection Children { get; } = new CompositionCollection();

        

        #endregion

        #region Methods

        public bool TryImport<TImport>(out TImport destination)
            where TImport : class
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
