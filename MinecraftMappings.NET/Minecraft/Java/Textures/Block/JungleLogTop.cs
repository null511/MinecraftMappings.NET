using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class JungleLogTop : JavaBlockTexture
    {
        public JungleLogTop() : base("Jungle Log, Top")
        {
            AddVersion("jungle_log_top")
                .WithDefaultModel<Java.Models.Block.JungleLog>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LogJungleTop>();
        }
    }
}
