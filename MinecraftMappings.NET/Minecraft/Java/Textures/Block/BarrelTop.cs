using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BarrelTop : JavaBlockTexture
    {
        public BarrelTop() : base("Barrel, Top")
        {
            AddVersion("barrel_top")
                .WithDefaultModel<Java.Models.Block.Barrel>()
                .MapsToBedrockBlock<BedrockBlocks.BarrelTop>()
                .WithMinVersion(new GameVersion(1, 14));
        }
    }
}
