using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Wheat_Stage7 : JavaBlockModel
    {
        public Wheat_Stage7() : base("Wheat, Stage 7")
        {
            AddVersion("wheat_stage7", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/crop")
                .AddTexture("crop", "block/wheat_stage7");
        }
    }
}
