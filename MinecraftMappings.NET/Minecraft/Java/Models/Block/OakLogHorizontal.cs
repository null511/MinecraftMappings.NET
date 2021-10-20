using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class OakLogHorizontal : JavaBlockModel
    {
        public OakLogHorizontal() : base("Oak Log, Horizontal")
        {
            AddVersion("oak_log_horizontal", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column_horizontal")
                .AddTexture("end", "block/oak_log_top")
                .AddTexture("side", "block/oak_log");
        }
    }
}
