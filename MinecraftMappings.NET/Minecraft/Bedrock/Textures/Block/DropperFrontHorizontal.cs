using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DropperFrontHorizontal : BedrockBlockTexture
    {
        public DropperFrontHorizontal() : base("Dropper Front, Horizontal")
        {
            AddVersion("dropper_front_horizontal")
                .MapsToJavaBlock<Java.Textures.Block.DropperFront>();
        }
    }
}
