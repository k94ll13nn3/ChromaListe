using Statiq.Common;
using Statiq.Core;

namespace Chromaliste.Web.Pipelines
{
    public class Resources : Pipeline
    {
        public Resources()
        {
            ProcessModules = new ModuleList
            {
                new CopyFiles("**/*{!.cshtml,!.md,!.scss,}")
            };
        }
    }
}