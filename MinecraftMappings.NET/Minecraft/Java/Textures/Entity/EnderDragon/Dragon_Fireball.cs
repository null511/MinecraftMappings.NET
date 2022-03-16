using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.EnderDragon
{
    public class Dragon_Fireball : JavaEntityTexture
    {
        public Dragon_Fireball() : base("Ender Dragon, Fireball")
        {
            AddVersion("dragon_fireball")
                .WithPath("entity/enderdragon");
                //.WithDefaultModel<Java.Models.Entity.EnderDragon>();
                //.MapsToBedrockEntity<BedrockEntities.Dragon_Fireball>();
        }
    }
}
