using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedstoneBlock : JavaBlockTexture
    {
        public RedstoneBlock() : base("Redstone Block")
        {
            AddVersion("redstone_block")
                .WithDefaultModel<Java.Models.Block.RedstoneBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RedstoneBlock>();
        }
    }
}
