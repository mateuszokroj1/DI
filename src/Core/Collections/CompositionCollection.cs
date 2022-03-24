using System;
using System.Collections;
using System.Collections.Generic;

namespace DI.Collections
{
    public sealed class CompositionCollection : IReadOnlyList<Composition>
    {
        #region Fields

        private readonly List<Composition> list = new List<Composition>();

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="IndexOutOfRangeException" />
        public Composition this[int index] => this.list[index];

        public int Count => this.list.Count;

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="composition"></param>
        /// <exception cref="ArgumentNullException"/>
        internal void Add(Composition composition)
        {
            /*Contracts.Contracts.NotNullArgument(composition);

            if (!this.list.Contains(composition))
                this.list.Add(composition);*/
        }

        internal void Remove(Composition composition)
        {
            if (composition != null)
                this.list.Remove(composition);
        }

        public IEnumerator<Composition> GetEnumerator() => this.list.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => this.list.GetEnumerator();

        #endregion
    }
}
