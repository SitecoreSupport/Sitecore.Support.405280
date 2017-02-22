using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sitecore.Common;
using Sitecore.Pipelines.SessionEnd;
using Sitecore.SecurityModel;

namespace Sitecore.Support
{
    public class SecurityDisabling
    {
        public void Process(SessionEndArgs endArgs)
        {
            Switcher<SecurityState, SecurityState>.Enter(SecurityState.Disabled);
        }
    }
}