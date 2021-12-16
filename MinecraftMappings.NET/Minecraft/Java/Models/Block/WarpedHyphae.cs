using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedHyphae : JavaBlockModel
    {
        public WarpedHyphae() : base("Warped Hyphae")
        {
            AddVersion("warped_hyphae", "1.16")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/warped_stem")
                .AddTexture("side", "block/warped_stem");
        }
    }
}
