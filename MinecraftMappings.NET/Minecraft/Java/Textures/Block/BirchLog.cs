using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchLog : JavaBlockTexture
    {
        public BirchLog() : base("Birch Log")
        {
            AddVersion("birch_log")
                .WithDefaultModel<Java.Models.Block.BirchLog>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LogBirch>();
        }
    }
}
