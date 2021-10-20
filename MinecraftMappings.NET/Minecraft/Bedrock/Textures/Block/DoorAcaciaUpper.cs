using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DoorAcaciaUpper : BedrockBlockTexture
    {
        public DoorAcaciaUpper() : base("Door Acacia Upper")
        {
            AddVersion("door_acacia_upper")
                .MapsToJavaBlock<AcaciaDoorTop>();
        }
    }
}
