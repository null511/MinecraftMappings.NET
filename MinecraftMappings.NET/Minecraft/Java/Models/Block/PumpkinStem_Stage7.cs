using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class PumpkinStem_Stage7 : JavaBlockModel
    {
        public PumpkinStem_Stage7() : base("Pumpkin Stem, Stage 7")
        {
            AddVersion("pumpkin_stem_stage7", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stem_growth7")
                .AddTexture("stem", "block/pumpkin_stem");
        }
    }
}
