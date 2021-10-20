using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class MelonStem_Stage0 : JavaBlockModel
    {
        public MelonStem_Stage0() : base("Melon Stem, Stage 0")
        {
            AddVersion("melon_stem_stage0", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stem_growth0")
                .AddTexture("stem", "block/melon_stem");
        }
    }
}
