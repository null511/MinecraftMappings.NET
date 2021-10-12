using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BarrelSide : JavaBlockData
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
