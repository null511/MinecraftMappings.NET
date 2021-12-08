using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeadHornCoralBlock : JavaBlockTexture
    {
        public DeadHornCoralBlock() : base("Dead Horn Coral Block")
        {
            AddVersion("dead_horn_coral_block");
                //.WithDefaultModel<Java.Models.Block.DeadHornCoralBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeadHornCoralBlock>();
        }
    }
}
