using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeetrootsStage0 : JavaBlockTexture
    {
        public BeetrootsStage0() : base("Beetroots, Stage 0")
        {
            AddVersion("beetroots_stage0")
                .WithDefaultModel<Java.Models.Block.BeetrootsStage0>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeetrootsStage0>();
        }
    }
}
