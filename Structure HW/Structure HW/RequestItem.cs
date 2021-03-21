using System;
using System.Collections.Generic;
using System.Text;

namespace Structure_HW
{
    class RequestItem
    {
        private Article article;
        private ushort count;
        public RequestItem(Article article, ushort count)
        {
            nArticle = article;
            Count = count;
        }
        public RequestItem() : this(default(Article), 0) { }
        public Article nArticle
        {
            get => article;
            set => article = value;
        }
        public ushort Count
        {
            get => count;
            set => count = value;
        }
    }
}
