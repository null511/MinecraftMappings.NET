using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Cobweb : JavaBlockData
    {
        public Cobweb() : base("Cobweb")
        {
            AddVersion("cobweb")
                .WithDefaultModel<Java.Models.Block.Cobweb>();
                //.MapsToBedrockBlock<BedrockBlocks.Cobweb>();
        }
    }
}
