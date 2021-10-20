using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaLogTop : JavaBlockTexture
    {
        public AcaciaLogTop() : base("Acacia Log, Top")
        {
            AddVersion("acacia_log_top")
                .WithDefaultModel<Java.Models.Block.AcaciaLog>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LogAcaciaTop>();
        }
    }
}
