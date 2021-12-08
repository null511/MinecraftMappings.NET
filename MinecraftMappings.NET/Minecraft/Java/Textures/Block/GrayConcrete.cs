using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrayConcrete : JavaBlockTexture
    {
        public GrayConcrete() : base("Gray Concrete")
        {
            AddVersion("gray_concrete")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcreteGray>();
        }
    }
}
