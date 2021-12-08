using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeadBubbleCoralBlock : JavaBlockTexture
    {
        public DeadBubbleCoralBlock() : base("Dead Bubble Coral Block")
        {
            AddVersion("dead_bubble_coral_block");
                //.WithDefaultModel<Java.Models.Block.DeadBrainCoralBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeadBrainCoralBlock>();
        }
    }
}
