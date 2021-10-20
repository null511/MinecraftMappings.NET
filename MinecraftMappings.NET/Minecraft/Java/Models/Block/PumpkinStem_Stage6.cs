using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class PumpkinStem_Stage6 : JavaBlockModel
    {
        public PumpkinStem_Stage6() : base("Pumpkin Stem, Stage 6")
        {
            AddVersion("pumpkin_stem_stage6", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stem_growth6")
                .AddTexture("stem", "block/pumpkin_stem");
        }
    }
}
