using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ChiseledSandstone : JavaBlockTexture
    {
        public ChiseledSandstone() : base("Chiseled Sandstone")
        {
            AddVersion("chiseled_sandstone");
                //.WithDefaultModel<Java.Models.Block.ChiseledSandstone>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ChiseledSandstone>();
        }
    }
}
