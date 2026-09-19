
using TShockAPI;

namespace RPGClasses;

public class RPGClasses
{
    public static readonly string Version = "0.1.0";

        public void Initialize()
            {
                    Commands.ChatCommands.Add(new Command("rpg.use", RPGCommand, "rpg"));
                        }

                            private void RPGCommand(CommandArgs args)
                                {
                                        if (args.Parameters.Count > 0 &&
                                                    args.Parameters[0].Equals("version", StringComparison.OrdinalIgnoreCase))
                                                            {
                                                                        args.Player.SendSuccessMessage(
                                                                                        $"[RPGClasses] Version {Version} - Plugin is working!"
                                                                                                    );
                                                                                                                return;
                                                                                                                        }

                                                                                                                                args.Player.SendInfoMessage(
                                                                                                                                            $"[RPGClasses] Plugin is working! Version {Version}"
                                                                                                                                                    );
                                                                                                                                                            args.Player.SendInfoMessage(
                                                                                                                                                                        "Use /rpg version"
                                                                                                                                                                                );
                                                                                                                                                                                    }
                                                                                                                                                                                    } 
                                                                                                                                                                                    
                                                                                                                                                                                        