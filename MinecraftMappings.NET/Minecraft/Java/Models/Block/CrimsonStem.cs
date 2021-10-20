using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CrimsonStem : JavaBlockModel
    {
        public CrimsonStem() : base("Crimson Stem")
        {
            AddVersion("crimson_stem", "1.16")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/crimson_stem_top")
                .AddTexture("side", "block/crimson_stem");
        }
    }
}
