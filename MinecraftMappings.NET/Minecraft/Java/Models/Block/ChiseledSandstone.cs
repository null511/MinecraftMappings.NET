using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ChiseledSandstone : JavaBlockModel
    {
        public ChiseledSandstone() : base("Chiseled Red Sandstone")
        {
            AddVersion("chiseled_sandstone", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/sandstone_top")
                .AddTexture("side", "block/chiseled_sandstone");
        }
    }
}
