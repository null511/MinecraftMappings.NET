using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class JungleLog : JavaBlockTexture
    {
        public JungleLog() : base("Jungle Log")
        {
            AddVersion("jungle_log")
                .WithDefaultModel<Java.Models.Block.JungleLog>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LogJungle>();
        }
    }
}
