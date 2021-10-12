using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BarrelBottom : JavaBlockData
    {
        public BarrelBottom() : base("Barrel Bottom")
        {
            AddVersion("barrel_bottom")
                .WithDefaultModel<Java.Models.Block.Barrel>()
                .MapsToBedrockBlock<BedrockBlocks.BarrelBottom>()
                .WithMinVersion(new GameVersion(1, 14));
        }
    }
}
