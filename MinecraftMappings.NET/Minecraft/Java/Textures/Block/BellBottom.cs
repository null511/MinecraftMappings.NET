using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BellBottom : JavaBlockTexture
    {
        public BellBottom() : base("Bell Bottom")
        {
            AddVersion("bell_bottom")
                .WithDefaultModel<Java.Models.Block.BellFloor>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BellBottom>();
        }
    }
}
