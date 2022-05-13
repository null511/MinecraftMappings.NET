using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Wheat_Stage4 : JavaBlockModel
    {
        public Wheat_Stage4() : base("Wheat, Stage 4")
        {
            AddVersion("wheat_stage4", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/crop")
                .AddTexture("crop", "block/wheat_stage4");
        }
    }
}
