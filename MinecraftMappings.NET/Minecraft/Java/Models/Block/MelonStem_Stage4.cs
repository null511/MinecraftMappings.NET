using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class MelonStem_Stage4 : JavaBlockModel
    {
        public MelonStem_Stage4() : base("Melon Stem, Stage 4")
        {
            AddVersion("melon_stem_stage4", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stem_growth4")
                .AddTexture("stem", "block/melon_stem");
        }
    }
}
