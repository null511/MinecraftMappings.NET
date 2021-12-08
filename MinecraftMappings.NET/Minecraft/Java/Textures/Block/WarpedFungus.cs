using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WarpedFungus : JavaBlockTexture
    {
        public WarpedFungus() : base("Warped Fungus")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("warped_fungus");
                //.WithDefaultModel<Java.Models.Block.WarpedFungus>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WarpedFungus>();
        }
    }
}
