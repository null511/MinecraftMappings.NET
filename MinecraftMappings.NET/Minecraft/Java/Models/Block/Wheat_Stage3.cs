using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Wheat_Stage3 : JavaBlockModel
    {
        public Wheat_Stage3() : base("Wheat, Stage 3")
        {
            AddVersion("wheat_stage3", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/crop")
                .AddTexture("crop", "block/wheat_stage3");
        }
    }
}
