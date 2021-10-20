using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchDoorTop : JavaBlockTexture
    {
        public BirchDoorTop() : base("Birch Door, Top")
        {
            AddVersion("birch_door_top")
                .WithDefaultModel<Java.Models.Block.BirchDoorTop>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorBirchUpper>();
        }
    }
}
