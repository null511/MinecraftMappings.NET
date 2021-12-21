using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DarkOakDoorTop : JavaBlockTexture
    {
        public DarkOakDoorTop() : base("Dark Oak Door Top")
        {
            AddVersion("dark_oak_door_top")
                .WithMinVersion("1.8")
                .WithDefaultModel<Java.Models.Block.DarkOakDoorTop>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorBigOakUpper>();
        }
    }
}
