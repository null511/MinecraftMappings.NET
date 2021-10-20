using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedStem : JavaBlockModel
    {
        public WarpedStem() : base("Warped Stem")
        {
            AddVersion("warped_stem", "1.16")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/warped_stem_top")
                .AddTexture("side", "block/warped_stem");
        }
    }
}
