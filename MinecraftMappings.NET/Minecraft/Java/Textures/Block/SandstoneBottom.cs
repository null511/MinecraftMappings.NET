using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SandstoneBottom : JavaBlockTexture
    {
        public SandstoneBottom() : base("Sandstone Bottom")
        {
            AddVersion("sandstone_bottom");
                //.WithDefaultModel<Java.Models.Block.Sandstone>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SandstoneBottom>();
        }
    }
}
