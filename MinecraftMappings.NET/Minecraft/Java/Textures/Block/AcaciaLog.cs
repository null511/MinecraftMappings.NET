using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaLog : JavaBlockTexture
    {
        public AcaciaLog() : base("Acacia Log")
        {
            AddVersion("acacia_log")
                .WithDefaultModel<Java.Models.Block.AcaciaLog>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LogAcacia>();
        }
    }
}
