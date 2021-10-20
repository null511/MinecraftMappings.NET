using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchLeaves : JavaBlockTexture
    {
        public BirchLeaves() : base("Birch Leaves")
        {
            AddVersion("birch_leaves")
                .WithDefaultModel<Java.Models.Block.BirchLeaves>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LeavesBirch>();
        }
    }
}
