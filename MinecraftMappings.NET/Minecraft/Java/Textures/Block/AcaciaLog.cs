using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaLog : JavaBlockTexture
    {
        public AcaciaLog() : base("Acacia Log")
        {
            AddVersion(1, "acacia_log")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.AcaciaLog>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LogAcacia>();
        }
    }
}
