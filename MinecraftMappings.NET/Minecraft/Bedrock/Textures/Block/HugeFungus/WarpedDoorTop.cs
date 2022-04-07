using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus
{
    public class WarpedDoorTop : BedrockBlockTexture
    {
        public WarpedDoorTop() : base("Warped Door Top")
        {
            AddVersion("warped_door_top")
                .MapsToJavaBlock<Java.Textures.Block.WarpedDoorTop>();
        }
    }
}
