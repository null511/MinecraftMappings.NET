using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Cobweb : JavaBlockTexture
    {
        public Cobweb() : base("Cobweb")
        {
            AddVersion("cobweb")
                .WithDefaultModel<Java.Models.Block.Cobweb>();
                //.MapsToBedrockBlock<BedrockBlocks.Cobweb>();
        }
    }
}
