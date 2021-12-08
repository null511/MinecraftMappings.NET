using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MediumAmethystBud : JavaBlockTexture
    {
        public MediumAmethystBud() : base("Medium Amethyst Bud")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(7, "medium_amethyst_bud")
                .WithMinVersion("1.17");
                //.WithDefaultModel<Java.Models.Block.MediumAmethystBud>()
                //.MapsToBedrockBlock<BedrockBlocks.MediumAmethystBud>();
        }
    }
}
