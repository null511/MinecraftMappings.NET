using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PodzolTop : JavaBlockTexture
    {
        public PodzolTop() : base("Podzol Top")
        {
            AddVersion("podzol_top");
                //.WithDefaultModel<Java.Models.Block.Podzol>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PodzolTop>();
        }
    }
}
