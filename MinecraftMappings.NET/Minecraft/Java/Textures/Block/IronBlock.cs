using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class IronBlock : JavaBlockTexture
    {
        public IronBlock() : base("Iron Block")
        {
            AddVersion("iron_block");
                //.WithDefaultModel<Java.Models.Block.IronBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.IronBlock>();
        }
    }
}
