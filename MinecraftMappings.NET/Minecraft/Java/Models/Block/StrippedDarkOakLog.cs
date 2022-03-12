using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class StrippedDarkOakLog : JavaBlockModel
    {
        public StrippedDarkOakLog() : base("Stripped Dark Oak Log")
        {
            AddVersion("stripped_dark_oak_log", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/stripped_dark_oak_log_top")
                .AddTexture("side", "block/stripped_dark_oak_log");
        }
    }
}
