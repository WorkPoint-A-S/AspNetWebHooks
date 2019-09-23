using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.AspNet.WebHooks.Extensions
{
    /// <summary>
    /// Implement .Net 4.6 functionality
    /// </summary>
    public static class TaskExtensions
    {
        /// <summary>
        /// Get completed task singleton
        /// </summary>
        public static readonly Task CompletedTask = Task.FromResult(false);
    }
}
