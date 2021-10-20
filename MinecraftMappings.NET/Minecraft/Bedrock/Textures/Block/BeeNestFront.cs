using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class BeeNestFront : BedrockBlockTexture
    {
        public BeeNestFront() : base("Bee Nest Front")
        {
            AddVersion("bee_nest_front")
                .MapsToJavaBlock<Java.Textures.Block.BeeNestFront>();
        }
    }
}
