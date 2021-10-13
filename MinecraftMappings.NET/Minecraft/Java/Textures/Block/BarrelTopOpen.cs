using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BarrelTopOpen : JavaBlockTexture
    {
        public BarrelTopOpen() : base("Barrel Top, Open")
        {
            AddVersion("barrel_top_open")
                .WithMinVersion("1.14")
                .MapsToBedrockBlock<BedrockBlocks.BarrelTopOpen>();
        }
    }
}
