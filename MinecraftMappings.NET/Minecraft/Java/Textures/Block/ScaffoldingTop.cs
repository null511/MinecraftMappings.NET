using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ScaffoldingTop : JavaBlockTexture
    {
        public ScaffoldingTop() : base("Scaffolding Top")
        {
            AddVersion("scaffolding_top");
                //.WithDefaultModel<Java.Models.Block.Scaffolding>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ScaffoldingTop>();
        }
    }
}
