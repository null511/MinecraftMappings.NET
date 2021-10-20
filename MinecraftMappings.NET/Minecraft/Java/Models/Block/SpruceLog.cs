using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SpruceLog : JavaBlockModel
    {
        public SpruceLog() : base("Spruce Log")
        {
            AddVersion("spruce_log", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/spruce_log_top")
                .AddTexture("side", "block/spruce_log");
        }
    }
}
