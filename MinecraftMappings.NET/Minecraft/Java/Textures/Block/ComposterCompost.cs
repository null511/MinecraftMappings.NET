using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ComposterCompost : JavaBlockTexture
    {
        public ComposterCompost() : base("Composter Compost")
        {
            AddVersion("composter_compost");
                //.WithDefaultModel<Java.Models.Block.ComposterCompost>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ComposterCompost>();
        }
    }
}
