using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class JungleLogHorizontal : JavaBlockModel
    {
        public JungleLogHorizontal() : base("Jungle Log, Horizontal")
        {
            AddVersion("jungle_log_horizontal", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column_horizontal")
                .AddTexture("end", "block/jungle_log_top")
                .AddTexture("side", "block/jungle_log");
        }
    }
}
