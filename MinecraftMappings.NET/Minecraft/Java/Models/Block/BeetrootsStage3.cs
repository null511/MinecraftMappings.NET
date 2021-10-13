using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BeetrootsStage3 : JavaBlockModel
    {
        public BeetrootsStage3() : base("Beetroots, Stage 3")
        {
            AddVersion("beetroots_stage3", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/crop")
                .AddTexture("crop", "block/beetroots_stage3");
        }
    }
}
