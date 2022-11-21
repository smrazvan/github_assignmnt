using Blogger_server.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy.Facade
{
    internal class ComplexSpellCheckingFacade
    {
        public void Check(Post post)
        {
            var SpellCheckingLib = new ComplexSpellCheckingWithRecommandations { };
            SpellCheckingLib.SimpleGrammarCheck(post);
            SpellCheckingLib.PhrasingCheck(post);
        }
    }
}
