using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaLog : JavaBlockModel
    {
        public AcaciaLog() : base("Acacia Log")
        {
            AddVersion("acacia_log", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/acacia_log_top")
                .AddTexture("side", "block/acacia_log");
        }
    }
}
