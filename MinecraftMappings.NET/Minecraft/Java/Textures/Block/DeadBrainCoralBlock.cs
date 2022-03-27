using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeadBrainCoralBlock : JavaBlockTexture
    {
        public DeadBrainCoralBlock() : base("Dead Brain Coral Block")
        {
            AddVersion("dead_brain_coral_block")
                .WithDefaultModel<Java.Models.Block.DeadBrainCoralBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeadBrainCoralBlock>();
        }
    }
}
