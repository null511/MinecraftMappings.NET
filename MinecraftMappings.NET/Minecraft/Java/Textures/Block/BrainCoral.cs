using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrainCoral : JavaBlockTexture
    {
        public BrainCoral() : base("Brain Coral")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("brain_coral");
                //.WithDefaultModel<Java.Models.Block.BrainCoral>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BrainCoral>();
        }
    }
}
