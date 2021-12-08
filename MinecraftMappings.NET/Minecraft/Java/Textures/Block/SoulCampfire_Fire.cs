using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SoulCampfire_Fire : JavaBlockTexture
    {
        public SoulCampfire_Fire() : base("Soul Campfire, Fire")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("soul_campfire_fire");
                //.WithDefaultModel<Java.Models.Block.SoulCampfire>()
                //.MapsToBedrockBlock<BedrockBlocks.SoulCampfire_Fire>();
        }
    }
}
