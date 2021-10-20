using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BirchLogHorizontal : JavaBlockModel
    {
        public BirchLogHorizontal() : base("Birch Log, Horizontal")
        {
            AddVersion("birch_log_horizontal", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column_horizontal")
                .AddTexture("end", "block/birch_log_top")
                .AddTexture("side", "block/birch_log");
        }
    }
}
