using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BeetrootsStage0 : JavaBlockModel
    {
        public BeetrootsStage0() : base("Beetroots, Stage 0")
        {
            AddVersion("beetroots_stage0", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/crop")
                .AddTexture("crop", "block/beetroots_stage0");
        }
    }
}
