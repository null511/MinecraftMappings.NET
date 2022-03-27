using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Deepslate : JavaBlockTexture
    {
        public Deepslate() : base("Deepslate")
        {
            AddVersion("deepslate")
                .WithDefaultModel<Java.Models.Block.Deepslate>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate>();
        }
    }
}
