using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class StrippedJungleLog : JavaBlockModel
    {
        public StrippedJungleLog() : base("Stripped Jungle Log")
        {
            AddVersion("stripped_jungle_log", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/stripped_jungle_log_top")
                .AddTexture("side", "block/stripped_jungle_log");
        }
    }
}
