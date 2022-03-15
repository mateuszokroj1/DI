namespace DI.Options
{
    public static class ExportOptionsExtensions
    {
        public static ExportOptions<TExport> Group<TGroup, TExport>(this ExportOptions<TExport> options)
            where TExport : TGroup
        {
            var type = typeof(TGroup);

            if (!type.IsInterface && !type.IsAbstract)
                throw new ExportException("Group type must be interface or abstract class.");

            if(options.Groups.IndexOf(type) < 0)
                options.Groups.Add(type);

            return options;
        }
    }
}
