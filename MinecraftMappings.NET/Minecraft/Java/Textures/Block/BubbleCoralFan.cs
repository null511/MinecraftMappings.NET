using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BubbleCoralFan : JavaBlockTexture
    {
        public BubbleCoralFan() : base("Bubble Coral Fan")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("bubble_coral_fan")
                .WithDefaultModel<Java.Models.Block.BubbleCoralFan>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BrainCoral>();
        }
    }
}
