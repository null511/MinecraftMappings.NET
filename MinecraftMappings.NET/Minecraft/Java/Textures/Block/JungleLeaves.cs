using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class JungleLeaves : JavaBlockTexture
    {
        public JungleLeaves() : base("Jungle Leaves")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("jungle_leaves")
                .WithDefaultModel<Java.Models.Block.JungleLeaves>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LeavesJungle>();
        }
    }
}
