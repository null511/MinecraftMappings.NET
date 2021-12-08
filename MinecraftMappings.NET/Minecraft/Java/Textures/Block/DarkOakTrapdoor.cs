using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DarkOakTrapdoor : JavaBlockTexture
    {
        public DarkOakTrapdoor() : base("Dark Oak Trapdoor")
        {
            AddVersion("dark_oak_trapdoor")
                .WithMinVersion("1.13");
                //.WithDefaultModel<Java.Models.Block.DarkOakDoorTop>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorBigOakUpper>();
        }
    }
}
