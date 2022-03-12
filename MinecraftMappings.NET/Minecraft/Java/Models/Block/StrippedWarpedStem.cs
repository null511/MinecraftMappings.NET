using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class StrippedWarpedStem : JavaBlockModel
    {
        public StrippedWarpedStem() : base("Stripped Warped Stem")
        {
            AddVersion("stripped_warped_stem", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/stripped_warped_stem_top")
                .AddTexture("side", "block/stripped_warped_stem");
        }
    }
}
