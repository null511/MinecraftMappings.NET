using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TubeCoralBlock : JavaBlockTexture
    {
        public TubeCoralBlock() : base("Tube Coral Block")
        {
            AddVersion("tube_coral_block");
                //.WithDefaultModel<Java.Models.Block.TubeCoralBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.TubeCoralBlock>();
        }
    }
}
