using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class JungleLog : JavaBlockModel
    {
        public JungleLog() : base("Jungle Log")
        {
            AddVersion("jungle_log", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/jungle_log_top")
                .AddTexture("side", "block/jungle_log");
        }
    }
}
