using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class StrippedBirchLog : JavaBlockModel
    {
        public StrippedBirchLog() : base("Stripped Birch Log")
        {
            AddVersion("stripped_birch_log", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/stripped_birch_log_top")
                .AddTexture("side", "block/stripped_birch_log");
        }
    }
}
