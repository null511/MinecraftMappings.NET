using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class PolishedBasalt : JavaBlockModel
    {
        public PolishedBasalt() : base("Polished Basalt")
        {
            AddVersion("polished_basalt", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/polished_basalt_top")
                .AddTexture("side", "block/polished_basalt_side");
        }
    }
}
