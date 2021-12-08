using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BellTop : JavaBlockTexture
    {
        public BellTop() : base("Bell Top")
        {
            AddVersion(4, "bell_top")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.BellFloor>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BellTop>();
        }
    }
}
