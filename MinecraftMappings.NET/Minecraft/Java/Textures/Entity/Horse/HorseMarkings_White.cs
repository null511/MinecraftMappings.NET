using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse
{
    public class HorseMarkings_White : JavaEntityTexture
    {
        public HorseMarkings_White() : base("Horse Markings, White")
        {
            AddVersion("horse_markings_white")
                .WithPath("entity/horse")
                .WithDefaultModel<Java.Models.Entity.Horse>();
                //.MapsToBedrockEntity<BedrockEntities.HorseMarkings_White>();
        }
    }
}
