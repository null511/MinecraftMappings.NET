using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CutRedSandstone : JavaBlockTexture
    {
        public CutRedSandstone() : base("Cut Red Sandstone")
        {
            AddVersion("cut_red_sandstone");
                //.WithDefaultModel<Java.Models.Block.CutRedSandstone>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CutRedSandstone>();
        }
    }
}
