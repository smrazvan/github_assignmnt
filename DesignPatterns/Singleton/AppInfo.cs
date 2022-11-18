using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class AppInfo
    {
        private static readonly Lazy<AppInfo> _lazyInstance = new Lazy<AppInfo>(() => new AppInfo(), true);

        public static AppInfo Instance
        {
            get
            {
                return _lazyInstance.Value;
            }
        }

        public void GetStats()
        {
            Console.WriteLine("your app has currently reached xxxx users");
        }

        private AppInfo() { }

    }
}
