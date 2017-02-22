using Sitecore.Common;
using Sitecore.Pipelines.SessionEnd;
using Sitecore.SecurityModel;

namespace Sitecore.Support
{
    public class SecurityRestoring
    {
        public void Process(SessionEndArgs endArgs)
        {
            Switcher<SecurityState, SecurityState>.Exit();
        }
    }
}
