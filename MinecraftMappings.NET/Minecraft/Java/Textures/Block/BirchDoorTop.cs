using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchDoorTop : JavaBlockTexture
    {
        public BirchDoorTop() : base("Birch Door, Top")
        {
            AddVersion(1, "birch_door_top")
                .WithMinVersion("1.8")
                .WithDefaultModel<Java.Models.Block.BirchDoorTop>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorBirchUpper>();
        }
    }
}
