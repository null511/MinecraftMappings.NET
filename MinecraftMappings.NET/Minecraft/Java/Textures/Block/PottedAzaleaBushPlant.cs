using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PottedAzaleaBushPlant : JavaBlockTexture
    {
        public PottedAzaleaBushPlant() : base("Potted Azalea Bush Plant")
        {
            AddVersion("potted_azalea_bush_plant");
                //.WithDefaultModel<Java.Models.Block.PottedAzaleaBushPlant>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PottedAzaleaBushPlant>();
        }
    }
}
