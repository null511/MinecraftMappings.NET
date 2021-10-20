using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class MelonStem_Stage2 : JavaBlockModel
    {
        public MelonStem_Stage2() : base("Melon Stem, Stage 2")
        {
            AddVersion("melon_stem_stage2", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stem_growth2")
                .AddTexture("stem", "block/melon_stem");
        }
    }
}
