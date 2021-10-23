using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class StrippedAcaciaLog : JavaBlockModel
    {
        public StrippedAcaciaLog() : base("Stripped Acacia Log")
        {
            AddVersion("stripped_acacia_log", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/stripped_acacia_log_top")
                .AddTexture("side", "block/stripped_acacia_log");
        }
    }
}
