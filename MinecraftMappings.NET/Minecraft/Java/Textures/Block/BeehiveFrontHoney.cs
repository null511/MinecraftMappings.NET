using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeehiveFrontHoney : JavaBlockTexture
    {
        public BeehiveFrontHoney() : base("Beehive Front, Honey")
        {
            AddVersion("beehive_front_honey")
                .WithDefaultModel<Java.Models.Block.Beehive>()
                .MapsToBedrockBlock<BedrockBlocks.BeehiveFrontHoney>();
        }
    }
}
