using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeehiveFront : JavaBlockTexture
    {
        public BeehiveFront() : base("Beehive Front")
        {
            AddVersion("beehive_front")
                .WithDefaultModel<Java.Models.Block.Beehive>()
                .MapsToBedrockBlock<BedrockBlocks.BeehiveFront>();
        }
    }
}
