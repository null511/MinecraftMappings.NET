using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StrippedJungleLog : JavaBlockTexture
    {
        public StrippedJungleLog() : base("Stripped Jungle Log")
        {
            AddVersion("stripped_jungle_log")
                .WithDefaultModel<Java.Models.Block.StrippedJungleLog>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StrippedJungleLog>();
        }
    }
}
