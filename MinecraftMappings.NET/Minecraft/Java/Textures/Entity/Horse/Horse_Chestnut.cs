using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse
{
    public class Horse_Chestnut : JavaEntityTexture
    {
        public Horse_Chestnut() : base("Horse, Chestnut")
        {
            AddVersion("horse_chestnut")
                .WithPath("entity/horse")
                .WithDefaultModel<Java.Models.Entity.Horse>();
                //.MapsToBedrockEntity<BedrockEntities.Horse_Chestnut>();
        }
    }
}
