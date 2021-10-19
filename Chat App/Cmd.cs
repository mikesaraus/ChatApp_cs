using System;

namespace Chat_App
{
    class Cmd
    {
        public string Base64_Encode(string str)
        {
            try
            {
                if (str == null)
                    return null;
                else
                {
                    byte[] data;
                    data = System.Text.Encoding.ASCII.GetBytes(str);
                    var result = Convert.ToBase64String(data);
                    return result;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error (Base64_Encode): " + ex.Message);
                return null;
            }
        }

        public string Base64_Decode(string str)
        {
            try
            {
                if (str == null)
                    return null;
                else
                {
                    byte[] data;
                    data = Convert.FromBase64String(str);
                    var result = System.Text.Encoding.ASCII.GetString(data);
                    return result;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error (Base64_Decode): " + ex.Message);
                return null;
            }
        }
    }
}
