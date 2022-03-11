using System;
using System.Windows.Forms;

//The C# API can be re-downloaded at https://wearedevs.net/d/Exploit%20API
//Make sure it is added as a reference if you decide to re-download
using WeAreDevs_API;

//The exploit itself auto updates. You never need to do work yourself!
//Just create the project once and let WeAreDevs do the work for you.
//Why is this free? Its because of the non-intrusive watermark the API adds
namespace Exploit_Template_with_WRDAPI
{
    public partial class Form1 : Form
    {
        private const string Https = "";

        //Creates object so we can make calls to WeAreDevs_API.
        readonly ExploitAPI api = new ExploitAPI();
        /*To see methods you can call, go to 
        The project in the solution explorer -> References -> Right click on WeAreDevs_API.dll ->
        View in Object Browser -> WeAreDevs_API -> WeAreDevs_API -> click Exploit API.
        This will then show a list of all functions you can use!*/

        public Form1()
        {
            InitializeComponent();
        }

        //The exploit must be injected before calling any other function!
        private void BtnInject_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        //Executes the lua script
        private void BtnExecute_Click(object sender, EventArgs e)
        {
            string script = inputScript.Text;
            api.SendLuaScript(script);
        }

        //Sets your player's walkspeed to 100
        //Quick command button using a Lua script
        private void BtnSpeed_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game:HttpGet(('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'),true))()");
        }

        //Gives your player btools
        //Quick command button using a pre-built command
        private void BtnBtools_Click(object sender, EventArgs e)
        {
            api.DoBTools();
        }

        //Example usage of a dynamic command
        //Quick command button using a pre-built command, but this one grab's the user input
        //Teleports the player to a player of the specified username
        private void BtnTPTo_Click(object sender, EventArgs e)
        {
            string username = inputTPTo.Text;
            api.TeleportToPlayer(username);
        }

        //Changes UI text to say if the exploit is injected or not
        //Challenge: Try making the attach button only show if the exploit is not injected
        private void CheckInjected()
        {
            if (api.isAPIAttached())
            {
                //The exploit is injected and now ready to execute scripts/commands
                txtIsInjected.Text = "Inject Edildi!";
            }
            else
            {
                //The exploit is not injected... The client must inject
                txtIsInjected.Text = "Inject Edilmedi!";
            }
        }

        //Check if the exploit is injected on load
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckInjected();
        }

        //Check if the exploit is injected every 3 seconds
        private void InjectedChecker_Tick(object sender, EventArgs e)
        {
            CheckInjected();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game:HttpGet(('https://gitlab.com/Tsuniox/lua-stuff/-/raw/master/R15GUI.lua'),true))()");
        
        }

        private void txtIsInjected_Click(object sender, EventArgs e)
        {

        }

        private void inputTPTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game:HttpGet(('https://raw.githubusercontent.com/ionlol/Hexagon-fixed-for-July-28-Roblox-update-/main/fix'),true))()");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game:HttpGet(('https://pastebin.com/raw/Bmq4VhTX'),true))()");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game:HttpGet(('https://pastebin.com/raw/Caniwq2N'),true))()");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game:HttpGet(('https://raw.githubusercontent.com/PhoenixAceVFX/Roblox-Scripts/master/Click%20TP%20Tool.lua'),true))()");
        }


        private void button9_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game:HttpGet(('https://pastebin.com/raw/4CdHwkxj'),true))()");
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputScript.Text = Clipboard.GetText();

        }

        private void inputScript_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputScript.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game: HttpGet(('https://pastebin.com/raw/XEsQBKGa'), true))()");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game: HttpGet(('https://raw.githubusercontent.com/Ethanoj1/EclipseMM2/master/Script'), true))()");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game: HttpGet(('https://raw.githubusercontent.com/TurfuGoldy/GoldenScripts/main/EzPets.lua'), true))()");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game: HttpGet(('https://gist.githubusercontent.com/TurkOyuncu99/b19b733fb8e9e0299381653c50e21e49/raw/a0c7394ba4451c6c548979103aea600d89b70f32/xxxcccc'), true))()");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game: HttpGet(('https://gist.githubusercontent.com/TurkOyuncu99/811e25ec8cfcdaa9ae7026353288783c/raw/4b073a5c1a0a4e2ed7e2304c2e769eb440a371a9/h'), true))()");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game: HttpGet(('https://pastebinp.com/raw/Vs23XVsY'), true))()");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game: HttpGet(('https://raw.githubusercontent.com/Herrtt/Phantom-Forces-Cheat/main/Main.lua'), true))()");
        }
        
        private void button16_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game: HttpGet(('https://pastebinp.com/raw/Ktktkc8u'), true))()");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game: HttpGet(('https://pastebin.com/raw/H2hnu5NK'), true))()");
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game: HttpGet(('https://raw.githubusercontent.com/Rolesional/Rolesyazilim-V2-Turkish-Cheat-csgo/main/lisanslar.txt'), true))()");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game: HttpGet(('https://pastebin.com/raw/0MLPL32f'), true))()");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game: HttpGet(('https://pastebin.com/raw/bC97eAyR'), true))()");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game: HttpGet(('https://pastebin.com/raw/09NZMs4E'), true))()");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game: HttpGet(('https://pastebin.com/raw/YYVLbzVg'), true))()");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game: HttpGet(('https://raw.githubusercontent.com/Rolesional/Rolesyazilim-V2-Turkish-Cheat-csgo/main/hwidler.txt'), true))()");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game: HttpGet(('https://raw.githubusercontent.com/1201for/V.G-Hub/main/V.Ghub'), true))()");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            api.SendLuaScript("loadstring(game: HttpGet(('https://paste.ee/r/r9gnA'), true))()");
        }
    }
}
