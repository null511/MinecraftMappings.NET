using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Tuff : JavaBlockTexture
    {
        public Tuff() : base("Tuff")
        {
            AddVersion("tuff");
                //.WithDefaultModel<Java.Models.Block.Tuff>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Tuff>();
        }
    }
}
