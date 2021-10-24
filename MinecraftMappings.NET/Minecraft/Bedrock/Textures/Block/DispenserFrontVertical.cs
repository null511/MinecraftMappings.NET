using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DispenserFrontVertical : BedrockBlockTexture
    {
        public DispenserFrontVertical() : base("Dispenser Front, Vertical")
        {
            AddVersion("dispenser_front_vertical")
                .MapsToJavaBlock<Java.Textures.Block.DispenserFrontVertical>();
        }
    }
}
