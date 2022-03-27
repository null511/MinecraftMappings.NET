using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ChiseledRedSandstone : JavaBlockModel
    {
        public ChiseledRedSandstone() : base("Chiseled Red Sandstone")
        {
            AddVersion("chiseled_red_sandstone", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/red_sandstone_top")
                .AddTexture("side", "block/chiseled_red_sandstone");
        }
    }
}
