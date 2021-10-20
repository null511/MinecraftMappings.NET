using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeetrootsStage1 : JavaBlockTexture
    {
        public BeetrootsStage1() : base("Beetroots, Stage 1")
        {
            AddVersion("beetroots_stage1")
                .WithDefaultModel<Java.Models.Block.BeetrootsStage1>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeetrootsStage1>();
        }
    }
}
