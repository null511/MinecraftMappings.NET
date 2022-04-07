using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DoorWoodLower : BedrockBlockTexture
    {
        public DoorWoodLower() : base("Door Wood Lower")
        {
            AddVersion("door_wood_lower")
                .MapsToJavaBlock<Java.Textures.Block.OakDoorBottom>();
        }
    }
}
