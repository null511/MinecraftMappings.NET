using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BasaltTop : JavaBlockTexture
    {
        public BasaltTop() : base("Basalt Top")
        {
            AddVersion(5, "basalt_top")
                .WithMinVersion("1.16")
                .WithDefaultModel<Java.Models.Block.Basalt>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BasaltTop>();
        }
    }
}
