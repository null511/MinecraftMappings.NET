using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackConcrete : JavaBlockTexture
    {
        public BlackConcrete() : base("Black Concrete")
        {
            AddVersion("black_concrete")
                .WithMinVersion(new GameVersion(1, 12))
                .MapsToBedrockBlock<BedrockBlocks.ConcreteBlack>();
        }
    }
}
