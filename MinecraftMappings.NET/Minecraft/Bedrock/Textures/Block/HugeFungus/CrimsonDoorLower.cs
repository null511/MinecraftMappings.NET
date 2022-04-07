using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus
{
    public class CrimsonDoorLower : BedrockBlockTexture
    {
        public CrimsonDoorLower() : base("Crimson Door Lower")
        {
            AddVersion("crimson_door_lower")
                .MapsToJavaBlock<Java.Textures.Block.CrimsonDoorBottom>();
        }
    }
}
