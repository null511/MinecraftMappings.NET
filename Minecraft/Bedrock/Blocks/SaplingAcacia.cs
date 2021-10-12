using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class SaplingAcacia : BedrockBlockData
    {
        public SaplingAcacia() : base("Sapling Acacia")
        {
            AddVersion("sapling_acacia", version => {
                version.MapsToJavaBlock = typeof(AcaciaSapling);
            });
        }
    }
}
