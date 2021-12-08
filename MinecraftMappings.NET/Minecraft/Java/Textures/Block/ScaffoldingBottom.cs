using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ScaffoldingBottom : JavaBlockTexture
    {
        public ScaffoldingBottom() : base("Scaffolding Bottom")
        {
            AddVersion("scaffolding_bottom");
                //.WithDefaultModel<Java.Models.Block.Scaffolding>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ScaffoldingBottom>();
        }
    }
}
