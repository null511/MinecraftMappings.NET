using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownConcrete : JavaBlockTexture
    {
        public BrownConcrete() : base("Brown Concrete")
        {
            AddVersion("brown_concrete")
                .WithMinVersion(new GameVersion(1, 12))
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcreteBrown>();
        }
    }
}
