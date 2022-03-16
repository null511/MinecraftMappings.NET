using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Axolotl
{
    public class Axolotl_Gold : JavaEntityTexture
    {
        public Axolotl_Gold() : base("Axolotl, Gold")
        {
            AddVersion("axolotl_gold")
                .WithPath("entity")
                .WithDefaultModel<Java.Models.Entity.Axolotl>();
                //.MapsToBedrockEntity<BedrockEntities.Axolotl_Gold>();
        }
    }
}
