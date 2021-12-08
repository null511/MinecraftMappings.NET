using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CampfireFire : JavaBlockTexture
    {
        public CampfireFire() : base("Campfire Fire")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("campfire_fire")
                .WithDefaultModel<Java.Models.Block.Campfire>();
                //.MapsToBedrockBlock<BedrockBlocks.CampfireFire>();
        }
    }
}
