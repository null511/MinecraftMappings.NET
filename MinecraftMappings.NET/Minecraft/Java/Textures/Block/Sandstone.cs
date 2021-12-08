using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Sandstone : JavaBlockTexture
    {
        public Sandstone() : base("Sandstone")
        {
            AddVersion("sandstone");
                //.WithDefaultModel<Java.Models.Block.Sandstone>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Sandstone>();
        }
    }
}
