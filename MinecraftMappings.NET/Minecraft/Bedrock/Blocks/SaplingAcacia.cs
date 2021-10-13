using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class SaplingAcacia : BedrockBlockTexture
    {
        public SaplingAcacia() : base("Sapling Acacia")
        {
            AddVersion("sapling_acacia")
                .MapsToJavaBlock<Java.Textures.Block.AcaciaSapling>();
        }
    }
}
