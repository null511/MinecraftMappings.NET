using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BeetrootsStage2 : JavaBlockModel
    {
        public BeetrootsStage2() : base("Beetroots, Stage 2")
        {
            AddVersion("beetroots_stage2", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/crop")
                .AddTexture("crop", "block/beetroots_stage2");
        }
    }
}
