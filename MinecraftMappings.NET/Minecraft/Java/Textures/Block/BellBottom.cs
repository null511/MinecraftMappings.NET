using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BellBottom : JavaBlockTexture
    {
        public BellBottom() : base("Bell Bottom")
        {
            AddVersion(4, "bell_bottom")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.BellFloor>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BellBottom>();
        }
    }
}
