using System;

namespace BL
{
    public class ParserException : Exception
    {
        byte error;
        public override string Message { get { return ErrorToString(); } }
        public ParserException(byte errorCode)
        {
            this.error = errorCode;
        }
        public string ErrorToString()
        {
            string s = "";
            switch (error)
            {
                case 1: s = "Invalid expression"; break;
                case 2: s = "Right closing bracket is missing ')'."; break;
                case 3: s = "Multiplier is missing"; break;
                case 4: s = "There is no dividend."; break;
                case 5: s = "Divider is missing"; break;
                case 6: s = "There is no addend"; break;
                case 7: s = "There is no deductible"; break;
                case 8: s = "The expression contains an invalid character"; break;
            }
            return s;
        }
    }
}
