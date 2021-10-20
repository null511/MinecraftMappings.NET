using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DoorAcaciaLower : BedrockBlockTexture
    {
        public DoorAcaciaLower() : base("Door Acacia Lower")
        {
            AddVersion("door_acacia_lower")
                .MapsToJavaBlock<AcaciaDoorBottom>();
        }
    }
}
