using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DoorBirchLower : BedrockBlockTexture
    {
        public DoorBirchLower() : base("Door Birch Lower")
        {
            AddVersion("door_birch_lower")
                .MapsToJavaBlock<Java.Textures.Block.BirchDoorBottom>();
        }
    }
}
