using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus
{
    public class WarpedTrapdoor : BedrockBlockTexture
    {
        public WarpedTrapdoor() : base("Warped Trapdoor")
        {
            AddVersion("warped_trapdoor")
                .MapsToJavaBlock<Java.Textures.Block.WarpedTrapdoor>();
        }
    }
}
