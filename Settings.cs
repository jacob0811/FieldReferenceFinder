using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldReferenceFinder
{
    /// <summary>
    /// This class can help you to store settings for your plugin
    /// </summary>
    /// <remarks>
    /// This class must be XML serializable
    /// </remarks>
    public class Settings
    {
        public string LastUsedOrganizationWebappUrl { get; set; }
        public string LastSelectedTable { get; set; }
        public string LastSelectedField { get; set; }
        public bool SearchWebResources { get; set; } = true;
        public bool SearchWorkflows { get; set; } = true;
        public bool SearchCloudFlows { get; set; } = true;
        public bool SearchCanvasApps { get; set; } = true;
    }
}