using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace SecurityIntegration.Library
{
    public static class StringExtensions
    {
        public static SecureString ToSecureString(this string str)
        {
            SecureString stringSegura = new SecureString();

            if ((str.Length > 0))
            {
                foreach (Char caractere in str.ToCharArray())
                {
                    stringSegura.AppendChar(caractere);
                }
            }

            return stringSegura;
        }

        public static string ToUnsecureString(this SecureString str)
        {
            var unmanagedPtr = Marshal.SecureStringToGlobalAllocUnicode(str);
            return Marshal.PtrToStringUni(unmanagedPtr);
        }
    }
}
