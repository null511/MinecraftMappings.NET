using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus
{
    public class WarpedDoorLower : BedrockBlockTexture
    {
        public WarpedDoorLower() : base("Warped Door Lower")
        {
            AddVersion("warped_door_lower")
                .MapsToJavaBlock<Java.Textures.Block.WarpedDoorBottom>();
        }
    }
}
