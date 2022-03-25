using System.Collections.Generic;

namespace DI.Definitions
{
    public class SectionDefinition
    {
        public virtual IList<SubSectionDefinition> SubSections { get; } = new List<SubSectionDefinition>();

        public virtual IList<ExportDefinition> Exports { get; } = new List<ExportDefinition>();
    }
}
