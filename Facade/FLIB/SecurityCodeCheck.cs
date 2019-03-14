using System;

namespace FLIB
{
    public class SecurityCodeCheck
    {
        private int SecurityCode { get; } = 1234;
        public bool IsCodeCorrect(int code)
        {
            return code == SecurityCode;
        }
        
    }
}
