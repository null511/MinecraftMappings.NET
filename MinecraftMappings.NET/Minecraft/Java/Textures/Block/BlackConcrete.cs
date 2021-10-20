using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackConcrete : JavaBlockTexture
    {
        public BlackConcrete() : base("Black Concrete")
        {
            AddVersion("black_concrete")
                .WithMinVersion(new GameVersion(1, 12))
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcreteBlack>();
        }
    }
}
