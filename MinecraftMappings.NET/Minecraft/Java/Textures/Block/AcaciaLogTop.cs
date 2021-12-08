using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaLogTop : JavaBlockTexture
    {
        public AcaciaLogTop() : base("Acacia Log, Top")
        {
            AddVersion(1, "acacia_log_top")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.AcaciaLog>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LogAcaciaTop>();
        }
    }
}
