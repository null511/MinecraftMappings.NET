using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeepslateTop : JavaBlockTexture
    {
        public DeepslateTop() : base("Deepslate Top")
        {
            AddVersion("deepslate_top");
                //.WithDefaultModel<Java.Models.Block.Deepslate>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate>();
        }
    }
}
