using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse
{
    public class Horse_DarkBrown : JavaEntityTexture
    {
        public Horse_DarkBrown() : base("Horse, Dark Brown")
        {
            AddVersion("horse_darkbrown")
                .WithPath("entity/horse")
                .WithDefaultModel<Java.Models.Entity.Horse>();
                //.MapsToBedrockEntity<BedrockEntities.Horse_DarkBrown>();
        }
    }
}
