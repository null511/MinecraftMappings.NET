using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DoorWoodLower : BedrockBlockTexture
    {
        public DoorWoodLower() : base("Door Wood Lower")
        {
            AddVersion("door_wood_lower")
                .MapsToJavaBlock<OakDoorBottom>();
        }
    }
}
