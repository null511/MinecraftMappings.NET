using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BirchLog : JavaBlockModel
    {
        public BirchLog() : base("Birch Log")
        {
            AddVersion("birch_log", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/birch_log_top")
                .AddTexture("side", "block/birch_log");
        }
    }
}
