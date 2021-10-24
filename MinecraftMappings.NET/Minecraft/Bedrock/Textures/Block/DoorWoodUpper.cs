using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DoorWoodUpper : BedrockBlockTexture
    {
        public DoorWoodUpper() : base("Door Wood Upper")
        {
            AddVersion("door_wood_upper")
                .MapsToJavaBlock<OakDoorTop>();
        }
    }
}
