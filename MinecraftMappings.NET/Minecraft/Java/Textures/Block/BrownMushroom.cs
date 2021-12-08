using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownMushroom : JavaBlockTexture
    {
        public BrownMushroom() : base("Brown Mushroom")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("brown_mushroom")
                .WithDefaultModel<Java.Models.Block.BrownMushroom>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.MushroomBrown>();
        }
    }
}
