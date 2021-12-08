using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DriedKelpSide : JavaBlockTexture
    {
        public DriedKelpSide() : base("Dried Kelp Side")
        {
            AddVersion("dried_kelp_side");
                //.WithDefaultModel<Java.Models.Block.DriedKelp>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DriedKelpSide>();
        }
    }
}
