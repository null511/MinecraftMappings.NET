using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PolishedDiorite : JavaBlockTexture
    {
        public PolishedDiorite() : base("Polished Diorite")
        {
            AddVersion("polished_diorite");
                //.WithDefaultModel<Java.Models.Block.PolishedDiorite>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PolishedDiorite>();
        }
    }
}
