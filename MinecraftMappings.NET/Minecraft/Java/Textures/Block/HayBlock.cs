using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class HayBlock : JavaBlockTexture
    {
        public HayBlock() : base("Hay Block")
        {
            AddVersion("hay_block")
                .WithMinVersion("1.6.1")
                .WithDefaultModel<Java.Models.Block.HayBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HayBlock>();
        }
    }
}
