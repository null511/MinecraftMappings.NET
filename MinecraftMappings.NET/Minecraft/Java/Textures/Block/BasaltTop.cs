using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BasaltTop : JavaBlockTexture
    {
        public BasaltTop() : base("Basalt Top")
        {
            AddVersion("basalt_top")
                .WithDefaultModel<Java.Models.Block.Basalt>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BasaltTop>();
        }
    }
}
