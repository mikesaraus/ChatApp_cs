using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_App
{
    public class Message
    {
        public Message()
        {
            From = null;
            Text = null;
            Timestamp = DateTime.Now.Ticks;
        }

        public string From { get; set; }
        public string Text { get; set; }
        public long Timestamp { get; set; }
    }
    public class PersonalData
    {
        public PersonalData()
        {
            Username = null;
            Name = null;
            Password = null;
            Registered = DateTime.Now.Ticks;
        }

        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public long Registered { get; set; }
    }

    public static class Paths
    {
        public static string Users { get; } = "users/";
        public static string Chat { get; } = "chat/";
    }
}
