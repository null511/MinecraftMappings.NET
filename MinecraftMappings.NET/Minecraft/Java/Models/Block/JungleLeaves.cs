using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class JungleLeaves : JavaBlockModel
    {
        public JungleLeaves() : base("Jungle Leaves")
        {
            AddVersion("jungle_leaves", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/leaves")
                .AddTexture("all", "block/jungle_leaves");
        }
    }
}
