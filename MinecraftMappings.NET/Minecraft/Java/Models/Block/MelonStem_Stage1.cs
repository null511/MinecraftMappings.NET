using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class MelonStem_Stage1 : JavaBlockModel
    {
        public MelonStem_Stage1() : base("Melon Stem, Stage 1")
        {
            AddVersion("melon_stem_stage1", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stem_growth1")
                .AddTexture("stem", "block/melon_stem");
        }
    }
}
