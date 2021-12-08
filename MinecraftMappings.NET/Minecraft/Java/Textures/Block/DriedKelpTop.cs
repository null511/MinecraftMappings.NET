using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DriedKelpTop : JavaBlockTexture
    {
        public DriedKelpTop() : base("Dried Kelp Top")
        {
            AddVersion("dried_kelp_top");
                //.WithDefaultModel<Java.Models.Block.DriedKelp>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DriedKelpTop>();
        }
    }
}
