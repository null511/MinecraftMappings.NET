using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OakDoorTop : JavaBlockTexture
    {
        public OakDoorTop() : base("Oak Door Top")
        {
            AddVersion("oak_door_top")
                .WithDefaultModel<Java.Models.Block.OakDoorTop>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorWoodUpper>();
        }
    }
}
