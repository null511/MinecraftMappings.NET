using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Wheat_Stage5 : JavaBlockModel
    {
        public Wheat_Stage5() : base("Wheat, Stage 5")
        {
            AddVersion("wheat_stage5", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/crop")
                .AddTexture("crop", "block/wheat_stage5");
        }
    }
}
