using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace AI_Clipboard_1
{
    public partial class Form1 : Form
    {
        private const int WM_HOTKEY = 0x0312;
        private const uint MOD_ALT = 0x0001;
        private const uint VK_1 = 0x31;  // '1' 
        private const uint VK_2 = 0x32;  // '2' 
        private const uint VK_3 = 0x33;  // '3' 
        private const uint VK_4 = 0x34;  // '3' 
        private const uint VK_5 = 0x35;  // '5' 
        private string currentFolder;

        private string actualAPIkey, maskedAPIkey;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public Form1()
        {
            InitializeComponent();
            //
            RegisterHotKey(this.Handle, 1, MOD_ALT, VK_1);
            RegisterHotKey(this.Handle, 2, MOD_ALT, VK_2);
            RegisterHotKey(this.Handle, 3, MOD_ALT, VK_3);
            RegisterHotKey(this.Handle, 4, MOD_ALT, VK_4);
            RegisterHotKey(this.Handle, 5, MOD_ALT, VK_5);
            //
            currentFolder = Directory.GetCurrentDirectory() + "\\";
            //
            byte[] encrypted = File.ReadAllBytes(currentFolder + "apikey.txt");
            this.actualAPIkey = Encoding.UTF8.GetString(ProtectedData.Unprotect(encrypted, null, DataProtectionScope.CurrentUser));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 
            string[] instructions = File.ReadAllLines(currentFolder + "instructions.txt");
            textBox1.Text = instructions[0];
            textBox2.Text = instructions[1];
            textBox3.Text = instructions[2];
            textBox4.Text = instructions[3];
            textBox5.Text = instructions[4];
            //
            HideOrShowAPIKEY();
            //
            toolStripStatusLabel1.Text = "";
            // 
            comboBox1.Text = "DeepSeek";
            // 
        }

        private void HideOrShowAPIKEY()
        {


            if (chkbxHide.Checked == true)
            {
                button1.Enabled = false;
                txtAPI.Enabled = false;
                comboBox1.Enabled = false;
                maskedAPIkey = actualAPIkey.Replace("1", "*")
                    .Replace("2", "*")
                    .Replace("3", "*")
                    .Replace("4", "*")
                    .Replace("5", "*")
                    .Replace("a", "*")
                    .Replace("c", "*")
                    .Replace("e", "*")
                    .Replace("h", "*")
                    .Replace("i", "*")
                    .Replace("k", "*")
                    .Replace("n", "*")
                ;

                txtAPI.Text = maskedAPIkey;

            }
            else
            {
                button1.Enabled = true;
                txtAPI.Enabled = true;
                comboBox1.Enabled = true;
                txtAPI.Text = actualAPIkey;
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {

                string[] instructions = File.ReadAllLines(currentFolder + "instructions.txt");


                int id = m.WParam.ToInt32();
                if (id == 1)
                {
                    if (Clipboard.ContainsText())
                    {
                        string text = Clipboard.GetText();
                        string filePath = Path.Combine(Application.StartupPath, "debug-original-content.txt");
                        File.WriteAllText(filePath, text);

                        AsynCall(instructions[0]);

                        toolStripStatusLabel1.Text = "Status: (ALT+1) request sent.";



                    }
                }
                if (id == 2)
                {
                    if (Clipboard.ContainsText())
                    {
                        string text = Clipboard.GetText();
                        string filePath = Path.Combine(Application.StartupPath, "debug-original-content.txt");
                        File.WriteAllText(filePath, text);

                        AsynCall(instructions[1]);



                        toolStripStatusLabel1.Text = "Status: (ALT+2) request sent.";
                    }
                }

                if (id == 3)
                {
                    if (Clipboard.ContainsText())
                    {
                        string text = Clipboard.GetText();
                        string filePath = Path.Combine(Application.StartupPath, "debug-original-content.txt");
                        File.WriteAllText(filePath, text);

                        AsynCall(instructions[2]);


                        toolStripStatusLabel1.Text = "Status: (ALT+3) request sent.";
                    }
                }

                if (id == 4)
                {
                    if (Clipboard.ContainsText())
                    {
                        string text = Clipboard.GetText();
                        string filePath = Path.Combine(Application.StartupPath, "debug-original-content.txt");
                        File.WriteAllText(filePath, text);

                        AsynCall(instructions[3]);



                        toolStripStatusLabel1.Text = "Status: (ALT+4) request sent.";

                    }
                }

                if (id == 5)
                {
                    if (Clipboard.ContainsText())
                    {
                        string text = Clipboard.GetText();
                        string filePath = Path.Combine(Application.StartupPath, "debug-original-content.txt");
                        File.WriteAllText(filePath, text);

                        AsynCall(instructions[4]);


                        toolStripStatusLabel1.Text = "Status: (ALT+5) request sent.";

                    }
                }

            }

            base.WndProc(ref m);
        }

        protected async void AsynCall(string instruction)
        {



            string clipboardText = Clipboard.GetText();
            string filePath = Path.Combine(Application.StartupPath, "debug-ai-content.txt");

            string systemMessage = "Please reply directly and precisely with the shortest answer, without follow-up questions.";
            string userMessage = instruction + " {" + clipboardText + "}";
            string reply = await CallAIAsync(actualAPIkey, systemMessage, userMessage);

            File.WriteAllText(filePath, reply);

            Clipboard.SetText(reply);



            toolStripStatusLabel1.Text = "Status: Received message from AI and saved to clipboard.";


        }



        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            UnregisterHotKey(this.Handle, 1);
            UnregisterHotKey(this.Handle, 2);
            UnregisterHotKey(this.Handle, 3);
            UnregisterHotKey(this.Handle, 4);
            UnregisterHotKey(this.Handle, 5);
            base.OnFormClosing(e);
        }

        public async Task<string> CallAIAsync(string token, string systemMessage, string userMessage)
        {
            string model = "";
            string uri = "";

            if (comboBox1.Items[0].ToString() == "DeepSeek")
            {
                model = "deepseek-chat";
                uri = "https://api.deepseek.com/chat/completions";
            }

            using var client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

            var body = new JsonObject
            {
                ["model"] = model,
                ["messages"] = new JsonArray
                {
                    new JsonObject { ["role"] = "system", ["content"] = systemMessage },
                    new JsonObject { ["role"] = "user",   ["content"] = userMessage }
                },
                ["stream"] = false,
                ["temperature"] = 1,
                ["max_tokens"] = 8192
            };

            var content = new StringContent(body.ToJsonString(), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(uri, content);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                var json = JsonNode.Parse(result);
                return json["choices"][0]["message"]["content"].ToString();
            }
            else
            {
                return $"error: {response.StatusCode} - {await response.Content.ReadAsStringAsync()}";
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            string newInstrucions = textBox1.Text + "\n" +
                textBox2.Text + "\n" +
                textBox3.Text + "\n" +
                textBox4.Text + "\n" +
                textBox5.Text;

            File.WriteAllText(currentFolder + "instructions.txt", newInstrucions);

            toolStripStatusLabel1.Text = "Status: Instructions saved.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAPI.Text.Contains("*"))
            {
                toolStripStatusLabel1.Text = "Status: Show the API key and save again.";
            }
            else
            {

                byte[] encrypted = ProtectedData.Protect(
                    Encoding.UTF8.GetBytes(txtAPI.Text),
                    null,
                    DataProtectionScope.CurrentUser);

                File.WriteAllBytes(currentFolder + "apikey.txt", encrypted);

                this.actualAPIkey = txtAPI.Text;

                HideOrShowAPIKEY();

                toolStripStatusLabel1.Text = "Status: API key saved.";

            }

        }



        private void ChkbxHide_CheckedChanged(object sender, EventArgs e)
        {
            HideOrShowAPIKEY();
        }



        private void btnHelp_Click(object sender, EventArgs e)
        {
            string helpMsg = "" +
                "This tool helps you quickly send frequent requests to AI. You can save your common instructions and bind them to hotkeys from Alt+1 to Alt+5. When you copy text to the clipboard and press a hotkey, the tool will send the saved instruction along with your clipboard content to the AI." + "\n\n" +
                "For example, if you often summarize web paragraphs, you can save the instruction \"Summarize this paragraph\". Then, after copying a paragraph, just press the hotkey (e.g., Alt+1), and the tool will automatically send it to the AI. Once the response is ready, the tool copies the AI's reply to your clipboard, so you can paste it (Ctrl+V) directly into any editor — speeding up your workflow." + "\n\n" +
                "This tool does not include any built-in AI API keys. You need to subscribe to an AI service yourself, enter your own API key at the top of the tool, and it will be encrypted and saved locally on your hard disk." + "\n\n" +
                "\n\n" +
                "Credit: garywmh@outlook.com" + "\n" +
                "Github: garywmh@outlook.com" +
                "";


            MessageBox.Show(helpMsg, "Help");
        }


    }
}
