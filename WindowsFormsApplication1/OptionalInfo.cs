using System;

namespace WindowsFormsApplication1
{
    public class OptionalInfo
    {
        private String tag;
        private String value;
        public OptionalInfo( String tag, String value)
        {
            this.tag = tag;
            this.value = value;
        }

        public String getTag()
        {
            return tag;
        }

        public String getValue()
        {
            return value;
        }
    }
}