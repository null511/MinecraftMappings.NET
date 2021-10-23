using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class HoneycombBlock : JavaBlockTexture
    {
        public HoneycombBlock() : base("Honeycomb Block")
        {
            AddVersion("honeycomb_block")
                .WithMinVersion("1.15")
                .WithDefaultModel<Java.Models.Block.HoneycombBlock>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Honeycomb>();
        }
    }
}
