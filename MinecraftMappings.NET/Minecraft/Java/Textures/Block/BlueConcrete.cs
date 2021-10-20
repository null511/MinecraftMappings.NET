using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueConcrete : JavaBlockTexture
    {
        public BlueConcrete() : base("Blue Concrete")
        {
            AddVersion("blue_concrete")
                .WithMinVersion(new GameVersion(1, 12))
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcreteBlue>();
        }
    }
}
