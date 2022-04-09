using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RepeatingCommandBlock_Conditional : JavaBlockTexture
    {
        public RepeatingCommandBlock_Conditional() : base("Repeating Command Block, Conditional")
        {
            AddVersion("repeating_command_block_conditional")
                .WithDefaultModel<Java.Models.Block.RepeatingCommandBlock_Conditional>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CommandBlockBack>();
        }
    }
}
