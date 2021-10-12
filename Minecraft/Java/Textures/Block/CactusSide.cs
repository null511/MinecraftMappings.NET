using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CactusSide : JavaBlockData
    {
        public CactusSide() : base("Cactus, Side")
        {
            AddVersion("cactus_side")
                .WithDefaultModel<Java.Models.Block.Cactus>();
            //.MapsToBedrockBlock<BedrockBlocks.CactusBottom>();
        }
    }
}
