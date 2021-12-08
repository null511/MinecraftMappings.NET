using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeadTubeCoralBlock : JavaBlockTexture
    {
        public DeadTubeCoralBlock() : base("Dead Tube Coral Block")
        {
            AddVersion("dead_tube_coral_Block");
                //.WithDefaultModel<Java.Models.Block.DeadTubeCoralBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeadTubeCoralBlock>();
        }
    }
}
