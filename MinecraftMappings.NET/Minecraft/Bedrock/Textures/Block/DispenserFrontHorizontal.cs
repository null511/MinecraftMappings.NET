using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DispenserFrontHorizontal : BedrockBlockTexture
    {
        public DispenserFrontHorizontal() : base("Dispenser Front, Horizontal")
        {
            AddVersion("dispenser_front_horizontal")
                .MapsToJavaBlock<Java.Textures.Block.DispenserFront>();
        }
    }
}
