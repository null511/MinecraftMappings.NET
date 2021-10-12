using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class FlowerAllium : BedrockBlockData
    {
        public FlowerAllium() : base("Flower Allium")
        {
            AddVersion("flower_allium", version => {
                version.MapsToJavaBlock = typeof(Allium);
            });
        }
    }
}
