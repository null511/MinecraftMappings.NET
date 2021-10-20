using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class MelonStem_Stage5 : JavaBlockModel
    {
        public MelonStem_Stage5() : base("Melon Stem, Stage 5")
        {
            AddVersion("melon_stem_stage5", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stem_growth5")
                .AddTexture("stem", "block/melon_stem");
        }
    }
}
