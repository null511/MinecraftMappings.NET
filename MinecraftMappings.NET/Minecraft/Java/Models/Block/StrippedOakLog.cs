using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class StrippedOakLog : JavaBlockModel
    {
        public StrippedOakLog() : base("Stripped Oak Log")
        {
            AddVersion("stripped_oak_log", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/stripped_oak_log_top")
                .AddTexture("side", "block/stripped_oak_log");
        }
    }
}
