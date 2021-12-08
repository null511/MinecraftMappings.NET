using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BubbleCoral : JavaBlockTexture
    {
        public BubbleCoral() : base("Bubble Coral")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("bubble_coral");
                //.WithDefaultModel<Java.Models.Block.BrainCoral>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BrainCoral>();
        }
    }
}
