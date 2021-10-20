using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class OakLog : JavaBlockModel
    {
        public OakLog() : base("Oak Log")
        {
            AddVersion("oak_log", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/oak_log_top")
                .AddTexture("side", "block/oak_log");
        }
    }
}
