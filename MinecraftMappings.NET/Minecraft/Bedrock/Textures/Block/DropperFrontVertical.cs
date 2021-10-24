using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DropperFrontVertical : BedrockBlockTexture
    {
        public DropperFrontVertical() : base("Dropper Front, Vertical")
        {
            AddVersion("dropper_front_vertical")
                .MapsToJavaBlock<Java.Textures.Block.DropperFrontVertical>();
        }
    }
}
