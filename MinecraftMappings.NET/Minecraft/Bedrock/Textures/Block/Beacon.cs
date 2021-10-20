using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Beacon : BedrockBlockTexture
    {
        public Beacon() : base("Beacon")
        {
            AddVersion("beacon")
                //.WithDefaultModel<Bedrock.Models.Block.Beacon>()
                .MapsToJavaBlock<Java.Textures.Block.Beacon>();
        }
    }
}
