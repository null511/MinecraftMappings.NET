using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Anvil : JavaBlockTexture
    {
        public Anvil() : base("Anvil")
        {
            AddVersion("anvil")
                .WithDefaultModel<Java.Models.Block.Anvil>()
                .MapsToBedrockBlock<BedrockBlocks.AnvilBase>();
        }
    }
}
