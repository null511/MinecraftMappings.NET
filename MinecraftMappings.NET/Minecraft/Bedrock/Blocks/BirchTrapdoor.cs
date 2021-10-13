using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BirchTrapdoor : BedrockBlockTexture
    {
        public BirchTrapdoor() : base("Birch Trapdoor")
        {
            AddVersion("birch_trapdoor")
                .MapsToJavaBlock<Java.Textures.Block.BirchTrapdoor>();
        }
    }
}
