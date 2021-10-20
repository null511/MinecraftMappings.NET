using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SpruceLogHorizontal : JavaBlockModel
    {
        public SpruceLogHorizontal() : base("Spruce Log, Horizontal")
        {
            AddVersion("spruce_log_horizontal", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column_horizontal")
                .AddTexture("end", "block/spruce_log_top")
                .AddTexture("side", "block/spruce_log");
        }
    }
}
