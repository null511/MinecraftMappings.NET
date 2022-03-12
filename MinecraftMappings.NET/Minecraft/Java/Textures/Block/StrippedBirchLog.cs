using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StrippedBirchLog : JavaBlockTexture
    {
        public StrippedBirchLog() : base("Stripped Birch Log")
        {
            AddVersion("stripped_birch_log")
                .WithDefaultModel<Java.Models.Block.StrippedBirchLog>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StrippedBirchLog>();
        }
    }
}
