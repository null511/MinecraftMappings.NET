using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedSandstoneTop : JavaBlockTexture
    {
        public RedSandstoneTop() : base("Red Sandstone Top")
        {
            AddVersion("red_sandstone_top");
                //.WithDefaultModel<Java.Models.Block.RedSandstoneTop>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RedSandstoneTop>();
        }
    }
}
