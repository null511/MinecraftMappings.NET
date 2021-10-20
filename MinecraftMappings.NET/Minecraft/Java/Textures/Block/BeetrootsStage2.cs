using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeetrootsStage2 : JavaBlockTexture
    {
        public BeetrootsStage2() : base("Beetroots, Stage 2")
        {
            AddVersion("beetroots_stage2")
                .WithDefaultModel<Java.Models.Block.BeetrootsStage2>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeetrootsStage2>();
        }
    }
}
