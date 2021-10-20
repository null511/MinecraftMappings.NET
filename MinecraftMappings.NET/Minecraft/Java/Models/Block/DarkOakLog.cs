using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DarkOakLog : JavaBlockModel
    {
        public DarkOakLog() : base("Dark Oak Log")
        {
            AddVersion("dark_oak_log", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/dark_oak_log_top")
                .AddTexture("side", "block/dark_oak_log");
        }
    }
}
