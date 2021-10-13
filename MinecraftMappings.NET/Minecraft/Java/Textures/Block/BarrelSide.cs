using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BarrelSide : JavaBlockTexture
    {
        public BarrelSide() : base("Barrel Side")
        {
            AddVersion("barrel_side")
                .WithDefaultModel<Java.Models.Block.Barrel>()
                .MapsToBedrockBlock<BedrockBlocks.BarrelSide>()
                .WithMinVersion(new GameVersion(1, 14));
        }
    }
}
