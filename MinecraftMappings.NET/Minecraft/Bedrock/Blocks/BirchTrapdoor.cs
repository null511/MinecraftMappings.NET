using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BirchTrapdoor : BedrockBlockData
    {
        public BirchTrapdoor() : base("Birch Trapdoor")
        {
            AddVersion("birch_trapdoor", version => {
                version.MapsToJavaBlock = typeof(Java.Textures.Block.BirchTrapdoor);
            });
        }
    }
}
