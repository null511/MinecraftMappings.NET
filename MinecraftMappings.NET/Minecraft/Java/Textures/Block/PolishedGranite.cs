using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PolishedGranite : JavaBlockTexture
    {
        public PolishedGranite() : base("Polished Granite")
        {
            AddVersion("polished_granite");
                //.WithDefaultModel<Java.Models.Block.PolishedGranite>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PolishedGranite>();
        }
    }
}
