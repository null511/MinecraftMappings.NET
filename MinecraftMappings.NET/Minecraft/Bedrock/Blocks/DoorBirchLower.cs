using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class DoorBirchLower : BedrockBlockTexture
    {
        public DoorBirchLower() : base("Door Birch Lower")
        {
            AddVersion("door_birch_lower")
                .MapsToJavaBlock<BirchDoorBottom>();
        }
    }
}
