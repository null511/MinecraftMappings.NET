using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StrippedBirchLogTop : JavaBlockTexture
    {
        public StrippedBirchLogTop() : base("Stripped Birch Log Top")
        {
            AddVersion("stripped_birch_log_top")
                .WithDefaultModel<Java.Models.Block.StrippedBirchLog>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StrippedBirchLogTop>();
        }
    }
}
