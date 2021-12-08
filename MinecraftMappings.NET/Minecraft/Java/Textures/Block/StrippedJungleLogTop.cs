using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StrippedJungleLogTop : JavaBlockTexture
    {
        public StrippedJungleLogTop() : base("Stripped Jungle Log Top")
        {
            AddVersion("stripped_jungle_log_top");
                //.WithDefaultModel<Java.Models.Block.StrippedJungleLog>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StrippedJungleLogTop>();
        }
    }
}
