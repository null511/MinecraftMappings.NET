using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ComposterReady : JavaBlockTexture
    {
        public ComposterReady() : base("Composter Ready")
        {
            AddVersion("composter_ready");
                //.WithDefaultModel<Java.Models.Block.ComposterCompost>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ComposterCompost>();
        }
    }
}
