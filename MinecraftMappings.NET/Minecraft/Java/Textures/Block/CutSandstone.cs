using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CutSandstone : JavaBlockTexture
    {
        public CutSandstone() : base("Cut Sandstone")
        {
            AddVersion("cut_sandstone");
                //.WithDefaultModel<Java.Models.Block.CutSandstone>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CutSandstone>();
        }
    }
}
