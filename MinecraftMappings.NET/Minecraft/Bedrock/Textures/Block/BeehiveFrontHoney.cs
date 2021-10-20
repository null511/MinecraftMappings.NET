using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class BeehiveFrontHoney : BedrockBlockTexture
    {
        public BeehiveFrontHoney() : base("Beehive Front, Honey")
        {
            AddVersion("beehive_front_honey")
                .MapsToJavaBlock<Java.Textures.Block.BeehiveFrontHoney>();
        }
    }
}
