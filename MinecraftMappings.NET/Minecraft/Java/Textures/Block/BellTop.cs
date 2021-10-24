using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BellTop : JavaBlockTexture
    {
        public BellTop() : base("Bell Top")
        {
            AddVersion("bell_top")
                .WithDefaultModel<Java.Models.Block.BellFloor>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BellTop>();
        }
    }
}
