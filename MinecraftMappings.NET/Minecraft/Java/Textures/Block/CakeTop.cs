using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CakeTop : JavaBlockTexture
    {
        public CakeTop() : base("Cake Top")
        {
            AddVersion("cake_top");
                //.WithDefaultModel<Java.Models.Block.Cake>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CakeBottom>();
        }
    }
}
