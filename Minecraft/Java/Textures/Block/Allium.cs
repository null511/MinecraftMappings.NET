using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Allium : JavaBlockData
    {
        public Allium() : base("Allium")
        {
            AddVersion("allium", version => {
                version.DefaultModel = typeof(Java.Models.Block.Allium);
                version.MapsToBedrockBlock = typeof(BedrockBlocks.FlowerAllium);
            });
        }
    }
}
