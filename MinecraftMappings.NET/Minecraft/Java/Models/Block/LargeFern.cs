using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class LargeFern : JavaBlockModel
    {
        public LargeFern() : base("Large Fern")
        {
            AddVersion("large_fern", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/tall_cross")
                .AddTexture("cross_top", "block/large_fern_top")
                .AddTexture("cross_bottom", "block/large_fern_bottom");
        }
    }
}
