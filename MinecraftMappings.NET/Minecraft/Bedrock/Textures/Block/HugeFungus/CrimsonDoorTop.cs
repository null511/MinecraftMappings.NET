using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus
{
    public class CrimsonDoorTop : BedrockBlockTexture
    {
        public CrimsonDoorTop() : base("Crimson Door Top")
        {
            AddVersion("crimson_door_top")
                .MapsToJavaBlock<Java.Textures.Block.CrimsonDoorTop>();
        }
    }
}
