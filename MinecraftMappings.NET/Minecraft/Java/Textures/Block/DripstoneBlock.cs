using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DripstoneBlock : JavaBlockTexture
    {
        public DripstoneBlock() : base("Dripstone Block")
        {
            AddVersion("dripstone_block")
                .WithDefaultModel<Java.Models.Block.DripstoneBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DripstoneBlock>();
        }
    }
}
