using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FarmlandDry : BedrockBlockTexture
    {
        public FarmlandDry() : base("Farmland, Dry")
        {
            AddVersion("farmland_dry")
                .MapsToJavaBlock<Java.Textures.Block.Farmland>();
        }
    }
}
