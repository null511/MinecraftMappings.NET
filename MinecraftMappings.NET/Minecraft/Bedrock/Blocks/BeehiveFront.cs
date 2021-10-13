using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BeehiveFront : BedrockBlockTexture
    {
        public BeehiveFront() : base("Beehive Front")
        {
            AddVersion("beehive_front")
                .MapsToJavaBlock<Java.Textures.Block.BeehiveFront>();
        }
    }
}
