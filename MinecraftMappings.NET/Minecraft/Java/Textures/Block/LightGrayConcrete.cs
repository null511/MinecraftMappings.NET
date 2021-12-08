using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LightGrayConcrete : JavaBlockTexture
    {
        public LightGrayConcrete() : base("Light Gray Concrete")
        {
            AddVersion("light_gray_concrete")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcreteLightGray>();
        }
    }
}
