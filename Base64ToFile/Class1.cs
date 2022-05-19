using System;
using System.IO;
using System.Xml;

namespace Base64ToFile
{
    public class Class1
    {
        public static string convertBase64ToFile(string base64String, string outputFilePath)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(base64String);
                File.WriteAllBytes(outputFilePath, bytes);
                return "success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
