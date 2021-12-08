using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GreenConcrete : JavaBlockTexture
    {
        public GreenConcrete() : base("Green Concrete")
        {
            AddVersion("green_concrete")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcreteGreen>();
        }
    }
}
