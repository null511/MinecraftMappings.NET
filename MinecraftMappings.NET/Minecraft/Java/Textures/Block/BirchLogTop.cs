using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchLogTop : JavaBlockTexture
    {
        public BirchLogTop() : base("Birch Log, Top")
        {
            AddVersion("birch_log_top")
                .WithDefaultModel<Java.Models.Block.BirchLog>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LogBirchTop>();
        }
    }
}
