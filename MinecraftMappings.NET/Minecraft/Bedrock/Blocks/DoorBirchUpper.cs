using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class DoorBirchUpper : BedrockBlockTexture
    {
        public DoorBirchUpper() : base("Door Birch Upper")
        {
            AddVersion("door_birch_upper")
                .MapsToJavaBlock<BirchDoorTop>();
        }
    }
}
