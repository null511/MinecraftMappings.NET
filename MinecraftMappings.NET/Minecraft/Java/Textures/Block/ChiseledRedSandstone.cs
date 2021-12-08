using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ChiseledRedSandstone : JavaBlockTexture
    {
        public ChiseledRedSandstone() : base("Chiseled Red Sandstone")
        {
            AddVersion("chiseled_red_sandstone");
                //.WithDefaultModel<Java.Models.Block.ChiseledRedSandstone>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ChiseledRedSandstone>();
        }
    }
}
