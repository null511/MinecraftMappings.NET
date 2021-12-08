using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LightBlueConcrete : JavaBlockTexture
    {
        public LightBlueConcrete() : base("Light Blue Concrete")
        {
            AddVersion("light_blue_concrete")
                .WithMinVersion("1.12");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcreteLightBlue>();
        }
    }
}
