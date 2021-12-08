using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CakeBottom : JavaBlockTexture
    {
        public CakeBottom() : base("Cake Bottom")
        {
            AddVersion("cake_bottom");
                //.WithDefaultModel<Java.Models.Block.Cake>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CakeBottom>();
        }
    }
}
