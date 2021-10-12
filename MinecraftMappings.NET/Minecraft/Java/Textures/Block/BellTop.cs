using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BellTop : JavaBlockData
    {
        public BellTop() : base("Bell, Top")
        {
            AddVersion("bell_top", version => {
                version.MapsToBedrockId = BedrockBlocks.BellTop.BlockId;
            });
        }
    }
}
