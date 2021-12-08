using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DriedKelpBottom : JavaBlockTexture
    {
        public DriedKelpBottom() : base("Dried Kelp Bottom")
        {
            AddVersion("dried_kelp_bottom");
                //.WithDefaultModel<Java.Models.Block.DriedKelp>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DriedKelpBottom>();
        }
    }
}
