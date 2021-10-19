using FireSharp;
using FireSharp.Response;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Chat_App
{
    public partial class ChatApp : Form
    {
        public ChatApp()
        {
            InitializeComponent();
        }

        private static ToolTip toolTip_BasicTitle = new ToolTip();
        private EventStreamResponse RealtimeMessages;
        private EventStreamResponse RealtimeUsers;
        private static FirebaseClient _client = (FirebaseClient)Program._client;
        private string msgFrom;

        public async void InitializeChat()
        {
            try
            {
                listBoxMessages.Items.Clear();
                listBox_DebugFrom.Items.Clear();
                listBox_DebugText.Items.Clear();
                listBox_DebugTimestamp.Items.Clear();
                listBox_DebugUID.Items.Clear();
                Program.MessagesId.Clear();
                Program.MessagesFrom.Clear();
                Program.MessagesText.Clear();
                Program.MessagesTimestamp.Clear();
                Program.LastMessageIdSelected = -1;
                label_DebugActiveIndex.Text = Program.LastMessageIdSelected.ToString();

                label_Other_Username.Text = Program._other_profile;
                // QueryBuilder orderFilter = QueryBuilder.New().OrderBy("Timestamp"); // Sort
                RealtimeMessages = await _client.OnAsync(Paths.Chat + (Program._other_profile == Program.GlobalChat ? Program.GlobalChat : Program._profile.Username + "/" + Program._other_profile),
                    added: (sendfrom, args, context) =>
                    {
                        Invoke((MethodInvoker)(() =>
                        {
                            //Gets the Unique IDs
                            string dataArgs = args.Data;
                            string paths = args.Path;
                            string[] split_path = paths.Split('/');
                            string key = split_path.Last();
                            string uniqueKey = split_path.Length > 2 ? split_path[split_path.Length - 2] : key;
                            if (paths.Contains("/From"))
                            {
                                listBox_DebugFrom.Items.Add(dataArgs);
                                listBox_DebugUID.Items.Add(uniqueKey);
                                Program.MessagesId.Add(uniqueKey);
                                Program.MessagesFrom.Add(dataArgs);
                                Console.WriteLine("From " + dataArgs + " @ Path: " + paths);
                                msgFrom = dataArgs;
                            }
                            else if (paths.Contains("/Text"))
                            {
                                try
                                {
                                    listBox_DebugText.Items.Add(dataArgs);
                                    Program.MessagesText.Add(dataArgs);
                                    Console.WriteLine("Message: " + dataArgs);
                                    listBoxMessages.Items.Add((msgFrom == Program._profile.Username ? ": " : "@" + msgFrom + ": ") + dataArgs);
                                    listBoxMessages.DrawMode = DrawMode.OwnerDrawVariable;
                                    listBoxMessages.DrawItem += new DrawItemEventHandler(listBoxMessages_DrawItem);
                                    listBoxMessages.SelectedIndex = listBoxMessages.Items.Count - 1;
                                }
                                catch (InvalidCastException err)
                                {
                                    Console.WriteLine("Error " + err.Message);
                                }
                            }
                            else if (paths.Contains("/Timestamp"))
                            {
                                listBox_DebugTimestamp.Items.Add(dataArgs);
                                Program.MessagesTimestamp.Add(Convert.ToInt64(dataArgs));
                            }
                        }));
                    }, changed: (sendfrom, args, context) =>
                    {
                        Console.WriteLine("Cht Changed on Path: " + args.Path);
                        Console.WriteLine("Chat Data: " + args.Data);
                    }, removed: (sendfrom, args, context) =>
                    {
                        Invoke((MethodInvoker)(() =>
                        {
                            Console.WriteLine("Chat Removed From: " + args.Path);
                            string uid = args.Path.Substring(1);
                            int id = Program.MessagesId.IndexOf(uid);
                            Console.WriteLine("To Delete: UID = " + uid + " ID = " + id);
                            if (id >= 0)
                            {
                                Console.WriteLine("listBoxMessages.Items: " + listBoxMessages.Items[id]);
                                listBoxMessages.Items.RemoveAt(id);
                                Program.MessagesId.RemoveAt(id);
                                Program.MessagesFrom.RemoveAt(id);
                                Program.MessagesText.RemoveAt(id);
                                Program.MessagesTimestamp.RemoveAt(id);
                                listBox_DebugFrom.Items.RemoveAt(id);
                                listBox_DebugText.Items.RemoveAt(id);
                                listBox_DebugTimestamp.Items.RemoveAt(id);
                                listBox_DebugUID.Items.RemoveAt(id);
                            }
                        }));
                    });
            }
            catch (InvalidCastException err)
            {
                Console.WriteLine("Error " + err.Message);
            }
        }


        void listBoxMessages_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            StringFormat sf = new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center, Trimming = StringTrimming.EllipsisCharacter, FormatFlags = StringFormatFlags.DirectionRightToLeft };

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                if (listBoxMessages.Items[e.Index].ToString().StartsWith(": "))
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.DimGray), e.Bounds);
                    e.Graphics.DrawString(listBoxMessages.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.WhiteSmoke), e.Bounds);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.Aqua), e.Bounds);
                    e.Graphics.DrawString(listBoxMessages.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.Black), e.Bounds);
                }
            }
            else
            {
                if (listBoxMessages.Items[e.Index].ToString().StartsWith(": "))
                {
                    // e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold), new SolidBrush(c), new Rectangle(e.Bounds.Width /2, e.Bounds.Y, e.Bounds.Width / 2, e.Bounds.Height), sf);
                    e.Graphics.DrawString(listBoxMessages.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.Black), e.Bounds);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.DodgerBlue), e.Bounds);
                    e.Graphics.DrawString(listBoxMessages.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.WhiteSmoke), e.Bounds);
                }
            }
        }

        public async void UserGetters()
        {
            try
            {
                RealtimeUsers = await _client.OnAsync(Paths.Users,
                    added: (sendfrom, args, context) =>
                    {
                        Invoke((MethodInvoker)(() =>
                        {
                            string dataArgs = args.Data;
                            string paths = args.Path;
                            string[] split_path = paths.Split('/');
                            string key = split_path.Last();
                            string username = split_path.Length > 2 ? split_path[split_path.Length - 2] : key;
                            if (!listBoxUsers.Items.Contains(username) && username != Program._profile.Username)
                            {
                                Console.WriteLine("User Added: " + username);
                                Console.WriteLine("User Added on Path: " + paths);
                                Console.WriteLine("User Data: " + dataArgs);
                                listBoxUsers.Items.Add(username);
                            }
                        }));
                    }, changed: (sendfrom, args, context) =>
                    {
                        Console.WriteLine("User Changed on Path: " + args.Path);
                        Console.WriteLine("User Data: " + args.Data);
                    }, removed: (sendfrom, args, context) =>
                    {
                        Console.WriteLine("User Removed From: " + args.Path);
                    });
            }
            catch (InvalidCastException err)
            {
                Console.WriteLine("Error " + err.Message);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Program.Debugging)
            {
                Panel_Debug.Visible = true;
                Size = new Size(Size.Width, Size.Height + Panel_Debug.Height);
            }
            label_Username.Text = Program._profile.Name.Length > 25 ? Program._profile.Name.Substring(0, 21) + "..." : Program._profile.Name;
            UserGetters();
            listBoxUsers.SelectedItem = Program.GlobalChat;
        }

        private void listBoxUsers_SelectedItemChange(object sender, EventArgs e)
        {
            try
            {
                if (listBoxUsers.SelectedItem.ToString() != Program._other_profile)
                { 
                    // Call dispose to stop listening for events and create new
                    if (RealtimeMessages != null) RealtimeMessages.Cancel();
                    Program._other_profile = listBoxUsers.SelectedItem.ToString();
                    buttonClearChats.Visible = Program._other_profile == Program.GlobalChat ? false : true;
                    InitializeChat();
                }
                textMessage.Focus();
            }
            catch (InvalidCastException err)
            {
                Console.WriteLine("Error " + err.Message);
            }
        }

        private void Main_Dispose(object sender, EventArgs e)
        {
            //Call dispose to stop listening for events
            try
            {
                if (RealtimeMessages != null) RealtimeMessages.Dispose();
                if (RealtimeUsers != null) RealtimeUsers.Dispose();
                if (!Program.ViewMessageForm.IsDisposed) Program.ViewMessageForm.Close();
                if (!Program.ProfileForm.IsDisposed) Program.ProfileForm.Close();
            }
            catch (InvalidCastException err)
            {
                Console.WriteLine("Error " + err.Message);
            }
            Program.LoginForm.Show();
        }

        private void Main_Closing(object sender, FormClosingEventArgs e)
        {
            Program.Logout();
        }

        private void textMessage_KeyDown_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSend_Click(sender, null);
            }
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            string clean_message = textMessage.Text;
            string text_required_atleast = "abcdefghijklmnopqrstuvwxyz";
            try
            {
                if (clean_message.Length > 0 && text_required_atleast.ToCharArray().Any(req => clean_message.ToLower().Contains(req)))
                {
                    textMessage.ReadOnly = true;
                    buttonSend.Enabled = false;
                    Cursor = Cursors.WaitCursor;
                    var newMsg = new Message
                    {
                        From = Program._profile.Username,
                        Text = clean_message
                    };
                    PushResponse response = await _client.PushAsync(Paths.Chat + (Program._other_profile == Program.GlobalChat ? Program.GlobalChat : Program._profile.Username + "/" + Program._other_profile), newMsg);
                    if (Program._other_profile != Program.GlobalChat) await _client.SetAsync(Paths.Chat + (Program._other_profile == Program.GlobalChat ? Program.GlobalChat : Program._other_profile + "/" + Program._profile.Username) + "/" + response.Result.name, newMsg);
                    textMessage.Text = "";
                    textMessage.Focus();
                }
                else
                {
                    MessageBox.Show(this, "Invalid message, please type something else.", "Invalid Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textMessage.SelectAll();
                }
            }
            catch (InvalidCastException err)
            {
                Console.WriteLine("Error " + err.Message);
                MessageBox.Show(this, "Message sending failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textMessage.ReadOnly = false;
            buttonSend.Enabled = true;
            Cursor = Cursors.Hand;
        }

        private void ViewMessageDetails()
        {
            try
            {
                if (!Program.ViewMessageForm.IsDisposed) Program.ViewMessageForm.Close();
                if (listBoxMessages.SelectedIndex >= 0 && listBoxMessages.SelectedIndex < listBoxMessages.Items.Count)
                {
                    Program.LastMessageIdSelected = listBoxMessages.SelectedIndex;
                    if (Program.ViewMessageForm.IsDisposed) Program.ViewMessageForm = new ViewMessage();
                    Program.ViewMessageForm.Show();
                }
            }
            catch (InvalidCastException err)
            {
                Console.WriteLine("Error " + err.Message);
            }
            label_DebugActiveIndex.Text = Program.LastMessageIdSelected.ToString();
        }

        private void listBoxMessage_EventSetMessage(object sender, EventArgs e)
        {
            ViewMessageDetails();
        }

        private void listBoxMessages_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ViewMessageDetails();
            }
        }

        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMessageDetails();
        }

        private async void DeleteEntireConvo(Boolean everyone = false)
        {
            try
            {
                if (Program._other_profile != Program.GlobalChat) // Do Not Allow Delete for All Chats
                {
                    FirebaseResponse response = await _client.DeleteAsync(Paths.Chat + (Program._other_profile == Program.GlobalChat ? Program.GlobalChat : Program._profile.Username + "/" + Program._other_profile));
                    if (everyone) await _client.DeleteAsync(Paths.Chat + (Program._other_profile == Program.GlobalChat ? Program.GlobalChat : Program._other_profile + "/" + Program._profile.Username));
                }
            }
            catch (InvalidCastException err)
            {
                Console.WriteLine("Error " + err.Message);
            }
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxMessages.SelectedIndex >= 0 && listBoxMessages.SelectedIndex < listBoxMessages.Items.Count)
            {
                await Program.DeleteMessage(listBoxMessages.SelectedIndex);
            }
            else
            {
                MessageBox.Show(this, "Select a message to delete!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonClearChats_Click(object sender, EventArgs e)
        {
            DeleteEntireConvo(false);
        }

        private void buttonSend_MouseHover(object sender, EventArgs e)
        {
            toolTip_BasicTitle.Show("Send Message", buttonSend, 1000);
        }

        private void buttonClearChats_MouseHover(object sender, EventArgs e)
        {
            toolTip_BasicTitle.Show("Clear Chats", buttonClearChats, 1000);
        }

        private void listBoxMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.LastMessageIdSelected != listBoxMessages.SelectedIndex)
            {
                Program.LastMessageIdSelected = listBoxMessages.SelectedIndex;
                if (listBoxMessages.SelectedIndex >= 0 && listBoxMessages.SelectedIndex < listBoxMessages.Items.Count && !Program.ViewMessageForm.IsDisposed) Program.ViewMessageForm.Dispose();
            }
            label_DebugActiveIndex.Text = Program.LastMessageIdSelected.ToString();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.ProfileForm.IsDisposed) Program.ProfileForm = new Profile();
            Program.ProfileForm.Show();
        }
    }
}
