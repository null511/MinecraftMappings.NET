using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CommandBlock_Conditional : JavaBlockTexture
    {
        public CommandBlock_Conditional() : base("Command Block, Conditional")
        {
            AddVersion("command_block_conditional")
                .WithDefaultModel<Java.Models.Block.CommandBlock_Conditional>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CommandBlockBack>();
        }
    }
}
