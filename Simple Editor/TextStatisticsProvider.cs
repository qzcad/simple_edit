using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Editor
{
    internal class TextStatisticsProvider
    {
        private const int kb = 1024;
        private string text;

        public TextStatisticsProvider(string text)
        {
            this.text = text;
        }

        public int sizeKb()
        {
            return this.text.Length * sizeof(char) / kb;
        }
    }
}
