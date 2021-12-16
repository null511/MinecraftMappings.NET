using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BubbleCoralBlock : JavaBlockTexture
    {
        public BubbleCoralBlock() : base("Bubble Coral Block")
        {
            AddVersion("bubble_coral_block")
                .WithDefaultModel<Java.Models.Block.BubbleCoralBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BubbleCoralBlock>();
        }
    }
}
