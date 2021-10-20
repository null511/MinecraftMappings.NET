using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DarkOakLogHorizontal : JavaBlockModel
    {
        public DarkOakLogHorizontal() : base("Dark Oak Log, Horizontal")
        {
            AddVersion("dark_oak_log_horizontal", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column_horizontal")
                .AddTexture("end", "block/dark_oak_log_top")
                .AddTexture("side", "block/dark_oak_log");
        }
    }
}
