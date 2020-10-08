using System;
using System.Collections.Generic;

using DI.Collections;

namespace DI
{
    public class Composition
    {
        #region Fields

        private List<Export> exports = new List<Export>();

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
