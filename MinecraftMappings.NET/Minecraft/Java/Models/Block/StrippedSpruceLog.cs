using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class StrippedSpruceLog : JavaBlockModel
    {
        public StrippedSpruceLog() : base("Stripped Spruce Log")
        {
            AddVersion("stripped_spruce_log", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/stripped_spruce_log_top")
                .AddTexture("side", "block/stripped_spruce_log");
        }
    }
}
