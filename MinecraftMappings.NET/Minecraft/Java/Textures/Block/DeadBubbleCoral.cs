using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeadBubbleCoral : JavaBlockTexture
    {
        public DeadBubbleCoral() : base("Dead Bubble Coral")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("dead_bubble_coral")
                .WithDefaultModel<Java.Models.Block.DeadBrainCoral>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeadBrainCoral>();
        }
    }
}
