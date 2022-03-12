using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class StrippedCrimsonStem : JavaBlockModel
    {
        public StrippedCrimsonStem() : base("Stripped Crimson Stem")
        {
            AddVersion("stripped_crimson_stem", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/stripped_crimson_stem_top")
                .AddTexture("side", "block/stripped_crimson_stem");
        }
    }
}
