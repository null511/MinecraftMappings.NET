using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.EnderDragon
{
    public class Dragon_Exploding : JavaEntityTexture
    {
        public Dragon_Exploding() : base("Ender Dragon, Exploding")
        {
            AddVersion("dragon_exploding")
                .WithPath("entity/enderdragon")
                .WithDefaultModel<Java.Models.Entity.Dragon>();
                //.MapsToBedrockEntity<BedrockEntities.Dragon_Exploding>();
        }
    }
}
