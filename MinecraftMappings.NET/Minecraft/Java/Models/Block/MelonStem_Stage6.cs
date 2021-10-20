using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class MelonStem_Stage6 : JavaBlockModel
    {
        public MelonStem_Stage6() : base("Melon Stem, Stage 6")
        {
            AddVersion("melon_stem_stage6", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stem_growth6")
                .AddTexture("stem", "block/melon_stem");
        }
    }
}
