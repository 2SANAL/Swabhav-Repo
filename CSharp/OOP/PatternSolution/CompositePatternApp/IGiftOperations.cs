using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePatternApp
{
    interface IGiftOperations
    {
        void Add(GiftBase gift);
        void Remove(GiftBase gift);
    }
}
