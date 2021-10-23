using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StrippedAcaciaLogTop : JavaBlockTexture
    {
        public StrippedAcaciaLogTop() : base("Stripped Acacia Log Top")
        {
            AddVersion("stripped_acacia_log_top")
                .WithDefaultModel<Java.Models.Block.StrippedAcaciaLog>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StrippedAcaciaLogTop>();
        }
    }
}
