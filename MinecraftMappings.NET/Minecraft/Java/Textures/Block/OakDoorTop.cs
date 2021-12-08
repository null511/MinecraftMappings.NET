using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OakDoorTop : JavaBlockTexture
    {
        public OakDoorTop() : base("Oak Door Top")
        {
            AddVersion("door_top")
                .WithMaxVersion("1.8")
                .WithDefaultModel<Java.Models.Block.OakDoorTop>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorWoodUpper>();

            AddVersion("oak_door_top")
                .WithMinVersion("1.8")
                .WithDefaultModel<Java.Models.Block.OakDoorTop>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorWoodUpper>();
        }
    }
}
