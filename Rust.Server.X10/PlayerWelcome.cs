namespace Oxide.Plugins
{
    [Info("Player welcome message", "Kwicot", "0.0.1")]
    public class PlayerWelcome : RustPlugin
    {
        private PluginConfig _config;
        void Init()
        {
            _config = Config.ReadObject<PluginConfig>();
        }

        [ChatCommand("PlayerWelcome")]
        void cmdPlayerWelcome(BasePlayer player, string command, string[] args)
        {
            
        }
        
        
        
        

        protected override void LoadDefaultConfig()
        {
            Config.WriteObject(GetDefaultConfig());
        }

        void SaveConfig()
        {
            Config.WriteObject(_config);
            Puts("Saved config");
        }

        PluginConfig GetDefaultConfig()
        {
            PluginConfig config = new PluginConfig()
            {
                ShowWelcomeMessage = true,
                WelcomeMessage = "Welcome {0} to {1} server"
            };
            return config;
        }
    }

    partial class PluginConfig
    {
        public bool ShowWelcomeMessage;
        public string WelcomeMessage;
    }
}