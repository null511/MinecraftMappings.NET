using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SugarCane : JavaBlockTexture
    {
        public SugarCane() : base("Sugar Cane")
        {
            AddVersion("sugar_cane")
                .WithDefaultModel<Java.Models.Block.SugarCane>();
                //.MapsToBedrockBlock<BedrockBlocks.LeavesSpruce>();
        }
    }
}
