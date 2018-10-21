using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace TengoFreeAutomation
{
    [TestClass]
    public class Class1
    {
        public void LaunchApp()
        {
            Application application = Application.Launch("foo.exe");
            Window window = application.GetWindow("bar", InitializeOption.NoCache);
        }
    }
}
