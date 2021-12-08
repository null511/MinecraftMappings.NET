using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedConcrete : JavaBlockTexture
    {
        public RedConcrete() : base("Red Concrete")
        {
            AddVersion("red_concrete")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcreteRed>();
        }
    }
}
