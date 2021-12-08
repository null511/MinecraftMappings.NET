using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedSandstone : JavaBlockTexture
    {
        public RedSandstone() : base("Red Sandstone")
        {
            AddVersion("red_sandstone");
                //.WithDefaultModel<Java.Models.Block.RedSandstone>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RedSandstone>();
        }
    }
}
