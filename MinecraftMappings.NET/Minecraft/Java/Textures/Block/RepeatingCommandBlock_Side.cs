using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RepeatingCommandBlock_Side : JavaBlockTexture
    {
        public RepeatingCommandBlock_Side() : base("Repeating Command Block, Side")
        {
            AddVersion("repeating_command_block_side")
                .WithDefaultModel<Java.Models.Block.RepeatingCommandBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CommandBlockBack>();
        }
    }
}
