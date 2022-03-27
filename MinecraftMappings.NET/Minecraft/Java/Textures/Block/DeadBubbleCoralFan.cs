using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeadBubbleCoralFan : JavaBlockTexture
    {
        public DeadBubbleCoralFan() : base("Dead Bubble Coral Fan")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("dead_bubble_coral_fan")
                .WithDefaultModel<Java.Models.Block.DeadBrainCoralFan>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeadBrainCoralFan>();
        }
    }
}
