using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse
{
    public class HorseMarkings_BlackDots : JavaEntityTexture
    {
        public HorseMarkings_BlackDots() : base("Horse Markings, Black Dots")
        {
            AddVersion("horse_markings_blackdots")
                .WithPath("entity/horse")
                .WithDefaultModel<Java.Models.Entity.Horse>();
                //.MapsToBedrockEntity<BedrockEntities.HorseMarkings_BlackDots>();
        }
    }
}
