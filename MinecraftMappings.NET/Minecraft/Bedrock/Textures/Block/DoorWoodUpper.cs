using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DoorWoodUpper : BedrockBlockTexture
    {
        public DoorWoodUpper() : base("Door Wood Upper")
        {
            AddVersion("door_wood_upper")
                .MapsToJavaBlock<Java.Textures.Block.OakDoorTop>();
        }
    }
}
