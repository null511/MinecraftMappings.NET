using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class RailNormal : BedrockBlockTexture
    {
        public RailNormal() : base("Rail Normal")
        {
            AddVersion("rail_normal")
                .MapsToJavaBlock<Java.Textures.Block.Rail>();
        }
    }
}
