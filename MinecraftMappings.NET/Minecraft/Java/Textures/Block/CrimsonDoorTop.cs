using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CrimsonDoorTop : JavaBlockTexture
    {
        public CrimsonDoorTop() : base("Crimson Door Top")
        {
            AddVersion("crimson_door_top")
                .WithDefaultModel<Java.Models.Block.CrimsonDoorTop>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorCrimsonUpper>();
        }
    }
}
