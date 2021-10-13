using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class MushroomBrown : BedrockBlockTexture
    {
        public MushroomBrown() : base("Mushroom Brown")
        {
            AddVersion("mushroom_brown")
                .MapsToJavaBlock<Java.Textures.Block.BrownMushroom>();
        }
    }
}
