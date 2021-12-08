using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrainCoralBlock : JavaBlockTexture
    {
        public BrainCoralBlock() : base("Brain Coral Block")
        {
            AddVersion("brain_coral_block");
                //.WithDefaultModel<Java.Models.Block.BrainCoral>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BrainCoral>();
        }
    }
}
