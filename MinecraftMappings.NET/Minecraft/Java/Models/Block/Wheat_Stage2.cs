using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Wheat_Stage2 : JavaBlockModel
    {
        public Wheat_Stage2() : base("Wheat, Stage 2")
        {
            AddVersion("wheat_stage2", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/crop")
                .AddTexture("crop", "block/wheat_stage2");
        }
    }
}
