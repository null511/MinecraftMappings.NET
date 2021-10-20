using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class MelonStem_Stage3 : JavaBlockModel
    {
        public MelonStem_Stage3() : base("Melon Stem, Stage 3")
        {
            AddVersion("melon_stem_stage3", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stem_growth3")
                .AddTexture("stem", "block/melon_stem");
        }
    }
}
