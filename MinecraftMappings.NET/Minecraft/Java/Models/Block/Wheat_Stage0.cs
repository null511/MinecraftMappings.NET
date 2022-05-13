using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Wheat_Stage0 : JavaBlockModel
    {
        public Wheat_Stage0() : base("Wheat, Stage 0")
        {
            AddVersion("wheat_stage0", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/crop")
                .AddTexture("crop", "block/wheat_stage0");
        }
    }
}
