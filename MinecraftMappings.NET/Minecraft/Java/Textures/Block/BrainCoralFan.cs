using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrainCoralFan : JavaBlockTexture
    {
        public BrainCoralFan() : base("Brain Coral Fan")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("brain_coral_fan");
                //.WithDefaultModel<Java.Models.Block.BrainCoral>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BrainCoral>();
        }
    }
}
