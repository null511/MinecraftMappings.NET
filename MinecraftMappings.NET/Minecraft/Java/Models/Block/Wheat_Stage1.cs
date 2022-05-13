using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Wheat_Stage1 : JavaBlockModel
    {
        public Wheat_Stage1() : base("Wheat, Stage 1")
        {
            AddVersion("wheat_stage1", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/crop")
                .AddTexture("crop", "block/wheat_stage1");
        }
    }
}
