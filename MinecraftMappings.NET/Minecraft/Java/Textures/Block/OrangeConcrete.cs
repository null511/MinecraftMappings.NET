using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OrangeConcrete : JavaBlockTexture
    {
        public OrangeConcrete() : base("Orange Concrete")
        {
            AddVersion("orange_concrete")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcreteOrange>();
        }
    }
}
