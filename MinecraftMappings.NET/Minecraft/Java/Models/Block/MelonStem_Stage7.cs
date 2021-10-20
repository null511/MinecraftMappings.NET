using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class MelonStem_Stage7 : JavaBlockModel
    {
        public MelonStem_Stage7() : base("Melon Stem, Stage 7")
        {
            AddVersion("melon_stem_stage7", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stem_growth7")
                .AddTexture("stem", "block/melon_stem");
        }
    }
}
