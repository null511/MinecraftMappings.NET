using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SandstoneTop : JavaBlockTexture
    {
        public SandstoneTop() : base("SandstoneTop")
        {
            AddVersion("sandstone_top");
                //.WithDefaultModel<Java.Models.Block.Sandstone>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SandstoneTop>();
        }
    }
}
