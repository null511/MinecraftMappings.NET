using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CommandBlock_Side : JavaBlockTexture
    {
        public CommandBlock_Side() : base("Command Block, Side")
        {
            AddVersion("command_block_side")
                .WithDefaultModel<Java.Models.Block.CommandBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CommandBlockBack>();
        }
    }
}
