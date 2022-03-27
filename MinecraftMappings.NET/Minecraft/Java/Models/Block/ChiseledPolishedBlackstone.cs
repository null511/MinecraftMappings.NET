using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ChiseledPolishedBlackstone : JavaBlockModel
    {
        public ChiseledPolishedBlackstone() : base("Chiseled Polished Blackstone")
        {
            AddVersion("chiseled_polished_blackstone", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/chiseled_polished_blackstone");
        }
    }
}
