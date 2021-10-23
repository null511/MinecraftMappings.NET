using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StrippedAcaciaLog : JavaBlockTexture
    {
        public StrippedAcaciaLog() : base("Stripped Acacia Log")
        {
            AddVersion("stripped_acacia_log")
                .WithDefaultModel<Java.Models.Block.StrippedAcaciaLog>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StrippedAcaciaLog>();
        }
    }
}
