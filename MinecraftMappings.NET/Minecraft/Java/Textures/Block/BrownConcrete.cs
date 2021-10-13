using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownConcrete : JavaBlockTexture
    {
        public BrownConcrete() : base("Brown Concrete")
        {
            AddVersion("brown_concrete")
                .WithMinVersion(new GameVersion(1, 12))
                .MapsToBedrockBlock<BedrockBlocks.ConcreteBrown>();
        }
    }
}
