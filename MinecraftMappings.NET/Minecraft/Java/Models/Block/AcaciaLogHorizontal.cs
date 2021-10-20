using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaLogHorizontal : JavaBlockModel
    {
        public AcaciaLogHorizontal() : base("Acacia Log, Horizontal")
        {
            AddVersion("acacia_log_horizontal", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column_horizontal")
                .AddTexture("end", "block/acacia_log_top")
                .AddTexture("side", "block/acacia_log");
        }
    }
}
