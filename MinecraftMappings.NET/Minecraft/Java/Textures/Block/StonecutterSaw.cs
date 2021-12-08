using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StonecutterSaw : JavaBlockTexture
    {
        public StonecutterSaw() : base("Stonecutter Saw")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("stonecutter_saw")
                .WithFrameCount(3)
                .WithDefaultModel<Java.Models.Block.Stonecutter>();
                //.MapsToBedrockBlock<BedrockBlocks.Grass>();
        }
    }
}
